using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebProject.Migrations
{
    /// <inheritdoc />
    public partial class hamza : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "BookPath", "ImagePath" },
                values: new object[] { "PIC Microcontroller and Embedded Systems.pdf", "embdedd.jpg" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "BookPath", "ImagePath" },
                values: new object[] { "Beginning App development with flutter.pdf", "flutter.jpg" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "BookPath", "ImagePath" },
                values: new object[] { "microprocessorsandinterfacing-d-151020182302-lva1-app6892.pdf", "microprocessor.jpg" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "BookPath", "ImagePath" },
                values: new object[] { "Data Base.pdf", "data base.jpg" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "BookPath", "ImagePath" },
                values: new object[] { "Happy Place (Emily Henry) (Books-Here).pdf", "happy place.jpg" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "BookPath", "ImagePath" },
                values: new object[] { "Reminders of Him (Colleen Hoover) (books-here.com).pdf", "reminders-of-him.jpg" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "BookPath", "ImagePath" },
                values: new object[] { "Twisted-Love-Ebook.pdf", "twisted-love.jpg" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "BookPath", "ImagePath" },
                values: new object[] { "PDFORALL.COM-Ugly Love by Colleen Hoover.pdf", "ugly love.jpg" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "BookPath", "ImagePath" },
                values: new object[] { "Verity-By-Colleen-Hoover.pdf", "verity.jpg" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "BookPath", "ImagePath" },
                values: new object[] { "2000-leagues-under-the-sea.pdf", "2000-leagues-under-the-sea.jpg" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "BookPath", "ImagePath" },
                values: new object[] { "adventures-of-huckleberry-finn.pdf", "adventures-of-huckleberry-finn.jpg" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "BookPath", "ImagePath" },
                values: new object[] { "bronze-magic.pdf", "bronze-magic.jpg" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "BookPath", "ImagePath" },
                values: new object[] { "fire-water.pdf", "fire-water.jpg" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "BookPath", "ImagePath" },
                values: new object[] { "in the heart of the sea.pdf", "in the heart of the sea.jpg" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "BookPath", "ImagePath" },
                values: new object[] { "induction.pdf", "induction.jpg" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "BookPath", "ImagePath" },
                values: new object[] { "~/books/adventures-of-huckleberry-finn.pdf", "~/books/pictures/adventures-of-huckleberry-finn.jpg" });

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
    }
}
