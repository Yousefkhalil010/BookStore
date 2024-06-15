using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebProject.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BookPath",
                table: "Books",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Books",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "BookPath", "ImagePath" },
                values: new object[] { "~/books/PIC Microcontroller and Embedded Systems.pdf", "~/books/pictures/embdedd.jpg" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "BookPath", "ImagePath" },
                values: new object[] { "~/books/Beginning App development with flutter.pdf", "~/books/pictures/flutter.jpg" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "BookPath", "ImagePath" },
                values: new object[] { "~/books/microprocessorsandinterfacing-d-151020182302-lva1-app6892.pdf", "~/books/pictures/microprocessor.jpg" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "BookPath", "ImagePath" },
                values: new object[] { "~/books/.pdf", "~/books/pictures/data base.jpg" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "BookPath", "ImagePath" },
                values: new object[] { "~/books/Data Base.pdf", "~/books/pictures/book lovers.jpg" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "BookPath", "ImagePath" },
                values: new object[] { "~/books/Happy Place (Emily Henry) (Books-Here).pdf", "~/books/pictures/happy place.jpg" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "BookPath", "ImagePath" },
                values: new object[] { "~/books/Reminders of Him (Colleen Hoover) (books-here.com).pdf", "~/books/pictures/reminders-of-him.jpg" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "BookPath", "ImagePath" },
                values: new object[] { "~/books/Twisted-Love-Ebook.pdf", "~/books/pictures/twisted-love.jpg" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "BookPath", "ImagePath" },
                values: new object[] { "~/books/PDFORALL.COM-Ugly Love by Colleen Hoover.pdf", "~/books/pictures/ugly love.jpg" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "BookPath", "ImagePath" },
                values: new object[] { "~/books/Verity-By-Colleen-Hoover.pdf", "~/books/pictures/verity.jpg" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "BookPath", "ImagePath" },
                values: new object[] { "~/books/2000-leagues-under-the-sea.pdf", "~/books/pictures/2000-leagues-under-the-sea.jpg" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "BookPath", "ImagePath", "Title" },
                values: new object[] { "~/books/adventures-of-huckleberry-finn.pdf", "~/books/pictures/adventures-of-huckleberry-finn.jpg", "Hucklebrerry Finn" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "BookPath", "ImagePath" },
                values: new object[] { "~/books/bronze-magic.pdf", "~/books/pictures/bronze-magic.jpg" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "BookPath", "ImagePath" },
                values: new object[] { "~/books/fire-water.pdf", "~/books/pictures/fire-water.jpg" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "BookPath", "ImagePath" },
                values: new object[] { "~/books/in the heart of the sea.pdf", "~/books/pictures/in the heart of the sea.jpg" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "BookPath", "ImagePath" },
                values: new object[] { "~/books/induction.pdf", "~/books/pictures/induction.jpg" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BookPath",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Books");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 14,
                column: "Title",
                value: "Mark Twain's");
        }
    }
}
