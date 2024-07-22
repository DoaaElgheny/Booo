using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PortalDemo.Migrations
{
    /// <inheritdoc />
    public partial class hostTent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Host",
                table: "AbpTenants",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Host",
                table: "AbpTenants");
        }
    }
}
