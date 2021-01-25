using Microsoft.EntityFrameworkCore.Migrations;

namespace DigitalWallet_COPPI_.Migrations
{
    public partial class message : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: true),
                    userInput = table.Column<string>(nullable: true),
                    messageInput = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Messages");
        }
    }
}
