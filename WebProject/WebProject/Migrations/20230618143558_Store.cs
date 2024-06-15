using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebProject.Migrations
{
    /// <inheritdoc />
    public partial class Store : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admin",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admin", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    AuthorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.AuthorID);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    GenreID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.GenreID);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AuthorID = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GenreID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Books_Authors_AuthorID",
                        column: x => x.AuthorID,
                        principalTable: "Authors",
                        principalColumn: "AuthorID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Books_Genres_GenreID",
                        column: x => x.GenreID,
                        principalTable: "Genres",
                        principalColumn: "GenreID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Admin",
                columns: new[] { "ID", "Email", "Name", "Password" },
                values: new object[] { 1, "Hamza123123@gmail.com", "Hamza", "123123" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorID", "Name" },
                values: new object[,]
                {
                    { 1, "Morris Mano" },
                    { 2, "Thomas Floyd" },
                    { 3, "Muhammad Mazidi" },
                    { 4, "Rap Payne" },
                    { 5, "Atul Godse" },
                    { 6, "Ramez Elmasri" },
                    { 7, "Emily Henry" },
                    { 8, "Colleen Hoover" },
                    { 9, "Ana Huang" },
                    { 10, "Jules Verne" },
                    { 11, "Mark Twain" },
                    { 12, "Jennifer Ealey" },
                    { 13, "Bobbi Schemerhorn" },
                    { 14, "Nathaniel Philbrick" },
                    { 15, "T.K. Eldridge" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreID", "Name" },
                values: new object[,]
                {
                    { 1, "Engineering Books" },
                    { 2, "Romantic Books" },
                    { 3, "Adventure Books" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "ID", "AuthorID", "Description", "GenreID", "Title" },
                values: new object[,]
                {
                    { 1, 1, "Digital design material covers principles and concepts related to circuits, logic gates, and system architecture in digital systems", 1, "Digital design" },
                    { 2, 2, "Electronics material encompasses components and technologies used in the design, analysis, and implementation of electronic circuits and systems\r\n", 1, "Electronics" },
                    { 3, 3, "Embedded system material refers to the hardware components and resources used in the development of embedded systems\r\n", 1, "Embedded system" },
                    { 4, 4, "Flutter Material is a UI framework that provides pre-designed components for building visually appealing cross-platform apps\r\n", 1, "Flutter" },
                    { 5, 5, "Microprocessor material focuses on the study of integrated circuits that function as the central processing unit in computer systems\r\n", 1, "Microprocessor" },
                    { 6, 6, "Database material involves the study of structured collections of data and their management, organization, and retrieval methods\r\n", 1, "Database" },
                    { 7, 7, "Nora has been through enough break-ups to know she's the one men date before finding their happy-ever-after. Nora's sister, Libby, persuades her to swap her city desk for a month's break in Sunshine Falls, in the hope she might enjoy a holiday romance\r\n", 2, "Book Lovers" },
                    { 8, 7, "Sabrina, Cleo, Kimmy, and Parth are Harriet and Wyn's closest friends in the world, the family they chose, and their ride-or-die besties. Afraid to change the dynamic between the group, and ruin the last weekend at their beloved vacation home, they choose to keep their parting a secret\r\n", 2, "Happy Place" },
                    { 9, 8, "A troubled young mother yearns for a shot at redemption in this heartbreaking yet hopeful story from #1 New York Times bestselling author Colleen Hoover. After serving five years in prison for a tragic mistake, Kenna Rowan returns to the town where it all went wrong, hoping to reunite with her four-year-old daughter\r\n", 2, "reminders of him" },
                    { 10, 9, "Twisted Love - Twisted (Paperback) A scintillating romance about a cold-hearted man driven by vengeance whose heart starts to melt when he is forced to look after his best friend's sister, Twisted Love is essential reading for all fans of enemies-to-lovers stories\r\n", 2, "Twisted Love" },
                    { 11, 8, "Ugly Love is one of Colleen Hoover's most noteworthy releases. This story follows Tate, a woman who falls for a distraught and reticent man named Miles. When these two souls meet, their connection is undeniable. However, Miles is a broken man and he cannot offer Tate anything other than a physical relationship\r\n", 2, "Ugly Love" },
                    { 12, 8, "Verity is mainly about three people - struggling author Lowen Ashleigh, a man called Jeremy Crawford, and Jeremy's wife, Verity, who was recently left incapacitated by a car accident. Verity is a successful writer, but she is no longer able to continue her bestselling series\r\n", 2, "Verity" },
                    { 13, 10, "Twenty Thousand Leagues Under the Sea tells the story of three men who go to sea in search of a giant whale. They are taken prisoner on board the world's first submarine the Nautilus. The Nautilus travels through the world's seas. The men see amazing deep-sea creatures, and they travel to remote islands.\r\n", 3, "Twenty Thousand Leagues Under the Sea" },
                    { 14, 11, "Mark Twain's classic The Adventures of Huckleberry Finn (1884) is told from the point of view of Huck Finn, a barely literate teen who fakes his own death to escape his abusive, drunken father. He encounters a runaway slave named Jim, and the two embark on a raft journey down the Mississippi River.\r\n", 3, "Mark Twain's" },
                    { 15, 12, "Bronze Magic is a feel-good fantasy tale in the tradition pre-dating the horror and thriller fusions that have infiltrated the genre. Betrayed by his older brother after beating him in a magic tournament, Prince Tarkyn is condemned to prison for no good reason.\r\n", 3, "Bronze Magic" },
                    { 16, 13, "Fire and Water is the powerful true story of a woman's transformational journey working with the forces of nature. She loves the elements of nature and is a firefighter who faces many challenges not only on the job, but in her daily life.\r\n", 3, "Fire and Water " },
                    { 17, 14, "A recounting of a New England whaling ship's sinking by a giant whale in 1820, an experience that later inspired the great novel Moby-Dick. In the winter of 1820, the New England whaling ship Essex was assaulted by something no one could believe: a whale of mammoth size and will, and an almost human sense of vengeance.\r\n", 3, "in the heart of the sea" },
                    { 18, 15, "Induction is a story about prejudice, species, racial and gender persecution. A bitterness that goes back through multiple family lines and is growing through the next generation. T. K. Eldridge does a great job making a controversial topic easy to read by developing her characters into such relatable people\r\n", 3, "Induction" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_AuthorID",
                table: "Books",
                column: "AuthorID");

            migrationBuilder.CreateIndex(
                name: "IX_Books_GenreID",
                table: "Books",
                column: "GenreID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admin");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Genres");
        }
    }
}
