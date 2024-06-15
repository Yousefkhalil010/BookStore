using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebProject.Migrations
{
    /// <inheritdoc />
    public partial class Initiallll : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Email);
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Email", "Password" },
                values: new object[,]
                {
                    { "Yousef1231230@gmail.com", "123" },
                    { "Yousef1231231@gmail.com", "1234" },
                    { "Yousef1231232@gmail.com", "12345" },
                    { "Yousef1231233@gmail.com", "123456" },
                    { "Yousef1231234@gmail.com", "1234567" },
                    { "Yousef1231235@gmail.com", "12345678" },
                    { "Yousef1231236@gmail.com", "123456789" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
