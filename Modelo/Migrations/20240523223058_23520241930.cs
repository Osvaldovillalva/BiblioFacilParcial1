﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modelo.Migrations
{
    /// <inheritdoc />
    public partial class _23520241930 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 1,
                column: "FechaDevolucion",
                value: new DateTime(2024, 5, 20, 19, 30, 57, 855, DateTimeKind.Local).AddTicks(1117));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 2,
                column: "FechaDevolucion",
                value: new DateTime(2024, 5, 21, 19, 30, 57, 855, DateTimeKind.Local).AddTicks(1118));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 3,
                column: "FechaDevolucion",
                value: new DateTime(2024, 5, 22, 19, 30, 57, 855, DateTimeKind.Local).AddTicks(1120));

            migrationBuilder.UpdateData(
                table: "Multas",
                keyColumn: "MultaId",
                keyValue: 1,
                columns: new[] { "FechaFinalizacion", "FechaInicio" },
                values: new object[] { new DateTime(2024, 5, 20, 19, 30, 57, 855, DateTimeKind.Local).AddTicks(1157), new DateTime(2024, 5, 20, 19, 30, 57, 855, DateTimeKind.Local).AddTicks(1156) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 1,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2024, 5, 13, 19, 30, 57, 855, DateTimeKind.Local).AddTicks(1083), new DateTime(2024, 5, 13, 19, 30, 57, 855, DateTimeKind.Local).AddTicks(1064) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 2,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2024, 5, 18, 19, 30, 57, 855, DateTimeKind.Local).AddTicks(1087), new DateTime(2024, 5, 18, 19, 30, 57, 855, DateTimeKind.Local).AddTicks(1086) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 3,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2024, 5, 20, 19, 30, 57, 855, DateTimeKind.Local).AddTicks(1089), new DateTime(2024, 5, 20, 19, 30, 57, 855, DateTimeKind.Local).AddTicks(1088) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 1,
                column: "FechaDevolucion",
                value: new DateTime(2024, 5, 20, 19, 17, 59, 24, DateTimeKind.Local).AddTicks(1911));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 2,
                column: "FechaDevolucion",
                value: new DateTime(2024, 5, 21, 19, 17, 59, 24, DateTimeKind.Local).AddTicks(1916));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 3,
                column: "FechaDevolucion",
                value: new DateTime(2024, 5, 22, 19, 17, 59, 24, DateTimeKind.Local).AddTicks(1917));

            migrationBuilder.UpdateData(
                table: "Multas",
                keyColumn: "MultaId",
                keyValue: 1,
                columns: new[] { "FechaFinalizacion", "FechaInicio" },
                values: new object[] { new DateTime(2024, 5, 20, 19, 17, 59, 24, DateTimeKind.Local).AddTicks(1967), new DateTime(2024, 5, 20, 19, 17, 59, 24, DateTimeKind.Local).AddTicks(1966) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 1,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2024, 5, 13, 19, 17, 59, 24, DateTimeKind.Local).AddTicks(1873), new DateTime(2024, 5, 13, 19, 17, 59, 24, DateTimeKind.Local).AddTicks(1854) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 2,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2024, 5, 18, 19, 17, 59, 24, DateTimeKind.Local).AddTicks(1878), new DateTime(2024, 5, 18, 19, 17, 59, 24, DateTimeKind.Local).AddTicks(1877) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 3,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2024, 5, 20, 19, 17, 59, 24, DateTimeKind.Local).AddTicks(1880), new DateTime(2024, 5, 20, 19, 17, 59, 24, DateTimeKind.Local).AddTicks(1880) });
        }
    }
}
