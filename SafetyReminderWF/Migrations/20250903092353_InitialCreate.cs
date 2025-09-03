using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SafetyReminderWF.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Compliance",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Assessment = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Frequency = table.Column<int>(type: "int", nullable: true),
                    CurrentDT = table.Column<DateTime>(type: "dateTime(6)", nullable: true),
                    UpComingDT = table.Column<DateTime>(type: "dateTime(6)", nullable: true),
                    Fee = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    ReminderSent = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Remark = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Compliance", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Compliance");
        }
    }
}
