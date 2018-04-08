using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace TennApp.Migrations
{
    public partial class PErsonModelChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Persons",
                maxLength: 22,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 13,
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Persons",
                maxLength: 13,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 22,
                oldNullable: true);
        }
    }
}
