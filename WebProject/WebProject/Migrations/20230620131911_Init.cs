using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebProject.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "BookPath", "ImagePath" },
                values: new object[] { "Digital Design.pdf", "digital.jpg" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "BookPath", "ImagePath" },
                values: new object[] { "Electronics.pdf", "electronics.jpg" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "BookPath", "ImagePath" },
                values: new object[] { "~/books/Digital Design.pdf", "~/books/pictures/digital.jpg" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "BookPath", "ImagePath" },
                values: new object[] { "~/books/Electronics.pdf", "~/books/pictures/electronics.jpg" });
        }
    }
}
