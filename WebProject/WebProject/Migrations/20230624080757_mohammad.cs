using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebProject.Migrations
{
    /// <inheritdoc />
    public partial class mohammad : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Admin",
                keyColumn: "ID",
                keyValue: 1,
                column: "Name",
                value: "Hamza Hawasheen");

            migrationBuilder.InsertData(
                table: "Admin",
                columns: new[] { "ID", "Email", "Name", "Password" },
                values: new object[,]
                {
                    { 2, "Yousef123@gmail.com", "Yousef Khalil", "12345" },
                    { 3, "Mohammad123@gmail.com", "Mohammad Yahya", "54321" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Admin",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Admin",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Admin",
                keyColumn: "ID",
                keyValue: 1,
                column: "Name",
                value: "Hamza");
        }
    }
}
