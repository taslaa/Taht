using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Taht.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class DateAsString : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<string>(
                name: "AppointmentDate",
                table: "Appointments",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "AppointmentDate",
                table: "Appointments",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "Id", "AppointmentDate", "AppointmentTime", "CreatedAt", "IsBooked", "ModifiedAt" },
                values: new object[] { 1, new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Local), "12:00", new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Local), true, null });
        }
    }
}
