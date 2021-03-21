using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TimeKeepingBlazorServerApp.Migrations
{
    public partial class TimeKeepingTransactions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TimeKeepingTransactions",
                columns: table => new
                {
                    TimeKeepingTransactionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    TransactionTypeId = table.Column<int>(type: "int", nullable: false),
                    TransactionDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeKeepingTransactions", x => x.TimeKeepingTransactionId);
                    table.ForeignKey(
                        name: "FK_TimeKeepingTransactions_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TimeKeepingTransactions_TransactionTypes_TransactionTypeId",
                        column: x => x.TransactionTypeId,
                        principalTable: "TransactionTypes",
                        principalColumn: "TransactionTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TimeKeepingTransactions_EmployeeId",
                table: "TimeKeepingTransactions",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_TimeKeepingTransactions_TransactionTypeId",
                table: "TimeKeepingTransactions",
                column: "TransactionTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TimeKeepingTransactions");
        }
    }
}
