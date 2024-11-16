using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TodoServerApp.Migrations
{
    /// <inheritdoc />
    public partial class AddExecutorItem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Executors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Patronymic = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Executors", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Executors",
                columns: new[] { "Id", "Name", "Patronymic", "Surname" },
                values: new object[,]
                {
                    { 1, "Описан1 1", "Опис2323ание  задачи 1", "123" },
                    { 2, "Описание2323  задачи 2", "Описани2323е  задачи 2", "Зад23ача 2" },
                    { 3, "Описание323  задачи 3", "Описа2323ние  задачи 3", "Задач2323а 3" }
                });

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 8, 18, 38, 27, 572, DateTimeKind.Local).AddTicks(136));

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 8, 18, 38, 27, 572, DateTimeKind.Local).AddTicks(157));

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 8, 18, 38, 27, 572, DateTimeKind.Local).AddTicks(159));

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 8, 18, 38, 27, 572, DateTimeKind.Local).AddTicks(160));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Executors");

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 5, 17, 22, 49, 615, DateTimeKind.Local).AddTicks(4242));

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 5, 17, 22, 49, 615, DateTimeKind.Local).AddTicks(4261));

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 5, 17, 22, 49, 615, DateTimeKind.Local).AddTicks(4262));

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 5, 17, 22, 49, 615, DateTimeKind.Local).AddTicks(4263));
        }
    }
}
