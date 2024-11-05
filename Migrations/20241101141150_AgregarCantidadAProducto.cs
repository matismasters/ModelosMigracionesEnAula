﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ModelosMigracionesEnAula.Migrations
{
    /// <inheritdoc />
    public partial class AgregarCantidadAProducto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Cantidad",
                table: "Productos",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cantidad",
                table: "Productos");
        }
    }
}