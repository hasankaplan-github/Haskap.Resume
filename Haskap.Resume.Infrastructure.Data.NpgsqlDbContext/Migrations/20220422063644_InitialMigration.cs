using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Haskap.Resume.Infrastructure.Data.NpgsqlDbContext.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Message",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Subject_Value = table.Column<string>(type: "text", nullable: false),
                    Body_Value = table.Column<string>(type: "text", nullable: false),
                    SenderName_Value = table.Column<string>(type: "text", nullable: false),
                    SenderEmailAddress_Value = table.Column<string>(type: "text", nullable: false),
                    MessageDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsRead = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Message", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Message");
        }
    }
}
