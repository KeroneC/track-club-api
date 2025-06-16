using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace El1te_Spr1nt_Track_Core.Migrations
{
    /// <inheritdoc />
    public partial class SetDecimalPrecision : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: -2,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 16, 16, 4, 17, 14, DateTimeKind.Utc).AddTicks(1460));

            migrationBuilder.UpdateData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: -1,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 16, 16, 4, 17, 14, DateTimeKind.Utc).AddTicks(1457));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: -2,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 16, 16, 4, 17, 14, DateTimeKind.Utc).AddTicks(1343));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: -1,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 16, 16, 4, 17, 14, DateTimeKind.Utc).AddTicks(1340));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: -2,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 16, 15, 51, 51, 7, DateTimeKind.Utc).AddTicks(3415));

            migrationBuilder.UpdateData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: -1,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 16, 15, 51, 51, 7, DateTimeKind.Utc).AddTicks(3413));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: -2,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 16, 15, 51, 51, 7, DateTimeKind.Utc).AddTicks(3314));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: -1,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 16, 15, 51, 51, 7, DateTimeKind.Utc).AddTicks(3311));
        }
    }
}
