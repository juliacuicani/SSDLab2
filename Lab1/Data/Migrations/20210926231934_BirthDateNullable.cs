using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Lab1.Data.Migrations
{
    public partial class BirthDateNullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "EstablishedDate",
                table: "Teams",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Teams",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Teams");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EstablishedDate",
                table: "Teams",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);
        }
    }
}
