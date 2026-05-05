using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web.Data.Migrations.DbContext
{
    /// <inheritdoc />
    public partial class AutoMigration_DemoUNLZ_20260505190238 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdProvincia",
                table: "Eventos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProvinciaIdProvincia",
                table: "Eventos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Eventos_ProvinciaIdProvincia",
                table: "Eventos",
                column: "ProvinciaIdProvincia");

            migrationBuilder.AddForeignKey(
                name: "FK_Eventos_Provincias_ProvinciaIdProvincia",
                table: "Eventos",
                column: "ProvinciaIdProvincia",
                principalTable: "Provincias",
                principalColumn: "IdProvincia");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Eventos_Provincias_ProvinciaIdProvincia",
                table: "Eventos");

            migrationBuilder.DropIndex(
                name: "IX_Eventos_ProvinciaIdProvincia",
                table: "Eventos");

            migrationBuilder.DropColumn(
                name: "IdProvincia",
                table: "Eventos");

            migrationBuilder.DropColumn(
                name: "ProvinciaIdProvincia",
                table: "Eventos");
        }
    }
}
