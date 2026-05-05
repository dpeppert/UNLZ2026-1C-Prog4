using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web.Data.Migrations.DbContext
{
    /// <inheritdoc />
    public partial class AutoMigration_DemoUNLZ_20260428191301 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Audit_FechaAlta",
                table: "Compras",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Audit_FechaBaja",
                table: "Compras",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Audit_FechaModificacion",
                table: "Compras",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Audit_IdUsuarioAlta",
                table: "Compras",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Audit_IdUsuarioBaja",
                table: "Compras",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Audit_IdUsuarioModificacion",
                table: "Compras",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Audit_FechaAlta",
                table: "Compras");

            migrationBuilder.DropColumn(
                name: "Audit_FechaBaja",
                table: "Compras");

            migrationBuilder.DropColumn(
                name: "Audit_FechaModificacion",
                table: "Compras");

            migrationBuilder.DropColumn(
                name: "Audit_IdUsuarioAlta",
                table: "Compras");

            migrationBuilder.DropColumn(
                name: "Audit_IdUsuarioBaja",
                table: "Compras");

            migrationBuilder.DropColumn(
                name: "Audit_IdUsuarioModificacion",
                table: "Compras");
        }
    }
}
