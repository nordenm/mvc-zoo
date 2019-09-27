using Microsoft.EntityFrameworkCore.Migrations;

namespace ZooMVC.Migrations
{
    public partial class modified : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HabitatSpecie_Specie_SpecieId",
                table: "HabitatSpecie");

            migrationBuilder.DropColumn(
                name: "SpieceId",
                table: "HabitatSpecie");

            migrationBuilder.AlterColumn<int>(
                name: "SpecieId",
                table: "HabitatSpecie",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_HabitatSpecie_Specie_SpecieId",
                table: "HabitatSpecie",
                column: "SpecieId",
                principalTable: "Specie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HabitatSpecie_Specie_SpecieId",
                table: "HabitatSpecie");

            migrationBuilder.AlterColumn<int>(
                name: "SpecieId",
                table: "HabitatSpecie",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "SpieceId",
                table: "HabitatSpecie",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_HabitatSpecie_Specie_SpecieId",
                table: "HabitatSpecie",
                column: "SpecieId",
                principalTable: "Specie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
