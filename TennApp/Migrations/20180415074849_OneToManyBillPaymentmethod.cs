using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace TennApp.Migrations
{
    public partial class OneToManyBillPaymentmethod : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PaymentMethods_Bills_BillID",
                table: "PaymentMethods");

            migrationBuilder.DropIndex(
                name: "IX_PaymentMethods_BillID",
                table: "PaymentMethods");

            migrationBuilder.DropColumn(
                name: "BillID",
                table: "PaymentMethods");

            migrationBuilder.CreateIndex(
                name: "IX_Bills_PaymentMethodID",
                table: "Bills",
                column: "PaymentMethodID");

            migrationBuilder.AddForeignKey(
                name: "FK_Bills_PaymentMethods_PaymentMethodID",
                table: "Bills",
                column: "PaymentMethodID",
                principalTable: "PaymentMethods",
                principalColumn: "PaymentMethodID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bills_PaymentMethods_PaymentMethodID",
                table: "Bills");

            migrationBuilder.DropIndex(
                name: "IX_Bills_PaymentMethodID",
                table: "Bills");

            migrationBuilder.AddColumn<int>(
                name: "BillID",
                table: "PaymentMethods",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_PaymentMethods_BillID",
                table: "PaymentMethods",
                column: "BillID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentMethods_Bills_BillID",
                table: "PaymentMethods",
                column: "BillID",
                principalTable: "Bills",
                principalColumn: "BillID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
