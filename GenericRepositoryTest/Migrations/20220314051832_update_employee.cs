using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GenericRepositoryTest.Migrations
{
    public partial class update_employee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDateTime",
                table: "Employees",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "CreatorId",
                table: "Employees",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "EditDateTime",
                table: "Employees",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "EditorId",
                table: "Employees",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "LoginIP",
                table: "Employees",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LoginLocation",
                table: "Employees",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreateDateTime",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "CreatorId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "EditDateTime",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "EditorId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "LoginIP",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "LoginLocation",
                table: "Employees");
        }
    }
}
