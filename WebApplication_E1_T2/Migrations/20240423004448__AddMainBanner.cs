using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication_E1_T2.Migrations
{
    /// <inheritdoc />
    public partial class _AddMainBanner : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MainBanner",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TitleImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MetaTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MetaDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MetaKeywords = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MainBanner", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8be73604-586a-4462-8755-a6d02e69bc05", "AQAAAAIAAYagAAAAEAAmZnoiZReYkvXLAn1O6GRWM4kW8YNhXl+tLPsBreHSerr1nPcja4wzGLsGDq6xag==" });

            migrationBuilder.InsertData(
                table: "MainBanner",
                columns: new[] { "Id", "DateAdded", "MetaDescription", "MetaKeywords", "MetaTitle", "SubTitle", "Text", "Title", "TitleImagePath" },
                values: new object[] { new Guid("4aa76a4c-c59d-499a-84c1-06e6487a137a"), new DateTime(2024, 4, 23, 0, 44, 48, 247, DateTimeKind.Utc).AddTicks(3450), "default", "default", "default", "AAAAAAAAAAAAAAAAAAAAAAAA AAAAAAAAAAAAAAAAAAAAA", "default", "It's me Mario", "default" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                column: "DateAdded",
                value: new DateTime(2024, 4, 23, 0, 44, 48, 247, DateTimeKind.Utc).AddTicks(3436));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DateAdded",
                value: new DateTime(2024, 4, 23, 0, 44, 48, 247, DateTimeKind.Utc).AddTicks(3396));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                column: "DateAdded",
                value: new DateTime(2024, 4, 23, 0, 44, 48, 247, DateTimeKind.Utc).AddTicks(3425));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MainBanner");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f2a61ede-dc84-44c0-a4aa-176d6c666072", "AQAAAAIAAYagAAAAEO85sAAH/XqbvaBCpRIeDBeCSXTem2DbJhCTALBdaSNasekebEj7t1HAyWi/zuWH0A==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                column: "DateAdded",
                value: new DateTime(2024, 4, 15, 23, 49, 44, 616, DateTimeKind.Utc).AddTicks(4606));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DateAdded",
                value: new DateTime(2024, 4, 15, 23, 49, 44, 616, DateTimeKind.Utc).AddTicks(4573));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                column: "DateAdded",
                value: new DateTime(2024, 4, 15, 23, 49, 44, 616, DateTimeKind.Utc).AddTicks(4596));
        }
    }
}
