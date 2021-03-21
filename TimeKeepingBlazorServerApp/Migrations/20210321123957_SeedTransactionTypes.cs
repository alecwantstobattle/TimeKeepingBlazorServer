using Microsoft.EntityFrameworkCore.Migrations;

namespace TimeKeepingBlazorServerApp.Migrations
{
    public partial class SeedTransactionTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO TransactionTypes (TransactionTypeName) VALUES (N'IN')");
            migrationBuilder.Sql("INSERT INTO TransactionTypes (TransactionTypeName) VALUES (N'OUT')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
