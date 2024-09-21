using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kupac.Migrations
{
    /// <inheritdoc />
    public partial class AddMobilPhoneToCustomer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MobilPhone",
                table: "Customer",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MobilPhone",
                table: "Customer");
        }
    }
}
