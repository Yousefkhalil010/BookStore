using Microsoft.EntityFrameworkCore;

namespace WebProject.Models
{
    public class BookStoreContextModel : DbContext
    {
        public BookStoreContextModel(DbContextOptions<BookStoreContextModel> options)
            : base(options)
        { }
        public DbSet<BookModel> Books { get; set; } = null!;
        public DbSet<AdminModel> Admin { get; set; } = null!;
        public DbSet<AuthorModel> Authors { get; set; } = null!;
        public DbSet<GenreModel> Genres { get; set; } = null!;
        public DbSet<UserModel> User { get; set; } = null!;
        public object Name { get; internal set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookModel>().HasData(
                new BookModel
                {
                    ID = 1,
                    Title = "Digital design",
                    AuthorID = 1,
                    Description = "Digital design material covers principles and concepts related to circuits, logic gates, and system architecture in digital systems",
                    GenreID = 1,
                    BookPath = "Digital Design.pdf",
                    ImagePath = "digital.jpg"
                },
                new BookModel
                {
                    ID = 2,
                    Title = "Electronics",
                    AuthorID = 2,
                    Description = "Electronics material encompasses components and technologies used in the design, analysis, and implementation of electronic circuits and systems\r\n",
                    GenreID = 1,
                    BookPath = "Electronics.pdf",
                    ImagePath = "electronics.jpg"
                },
                new BookModel
                {
                    ID = 3,
                    Title = "Embedded system",
                    AuthorID = 3,
                    Description = "Embedded system material refers to the hardware components and resources used in the development of embedded systems\r\n",
                    GenreID = 1,
                    BookPath = "PIC Microcontroller and Embedded Systems.pdf",
                    ImagePath = "embdedd.jpg"
                },
                new BookModel
                {
                    ID = 4,
                    Title = "Flutter",
                    AuthorID = 4,
                    Description = "Flutter Material is a UI framework that provides pre-designed components for building visually appealing cross-platform apps\r\n",
                    GenreID = 1,
                    BookPath = "Beginning App development with flutter.pdf",
                    ImagePath = "flutter.jpg"
                },
                new BookModel
                {
                    ID = 5,
                    Title = "Microprocessor",
                    AuthorID = 5,
                    Description = "Microprocessor material focuses on the study of integrated circuits that function as the central processing unit in computer systems\r\n",
                    GenreID = 1,
                    BookPath = "microprocessorsandinterfacing-d-151020182302-lva1-app6892.pdf",
                    ImagePath = "microprocessor.jpg"
                },
                new BookModel
                {
                    ID = 6,
                    Title = "Database",
                    AuthorID = 6,
                    Description = "Database material involves the study of structured collections of data and their management, organization, and retrieval methods\r\n",
                    GenreID = 1,
                    BookPath = "Data Base.pdf",
                    ImagePath = "data base.jpg"
                },
                new BookModel
                {
                    ID = 7,
                    Title = "Book Lovers",
                    AuthorID = 7,
                    Description = "Nora has been through enough break-ups to know she's the one men date before finding their happy-ever-after. Nora's sister, Libby, persuades her to swap her city desk for a month's break in Sunshine Falls, in the hope she might enjoy a holiday romance\r\n",
                    GenreID = 2,
                    BookPath = "Book_Lovers_by_Emily_Henry.pdf",
                    ImagePath = "book lovers.jpg"
                },
                new BookModel
                {
                    ID = 8,
                    Title = "Happy Place",
                    AuthorID = 7,
                    Description = "Sabrina, Cleo, Kimmy, and Parth are Harriet and Wyn's closest friends in the world, the family they chose, and their ride-or-die besties. Afraid to change the dynamic between the group, and ruin the last weekend at their beloved vacation home, they choose to keep their parting a secret\r\n",
                    GenreID = 2,
                    BookPath = "Happy Place (Emily Henry) (Books-Here).pdf",
                    ImagePath = "happy place.jpg"
                },
                new BookModel
                {
                    ID = 9,
                    Title = "reminders of him",
                    AuthorID = 8,
                    Description = "A troubled young mother yearns for a shot at redemption in this heartbreaking yet hopeful story from #1 New York Times bestselling author Colleen Hoover. After serving five years in prison for a tragic mistake, Kenna Rowan returns to the town where it all went wrong, hoping to reunite with her four-year-old daughter\r\n",
                    GenreID = 2,
                    BookPath = "Reminders of Him (Colleen Hoover) (books-here.com).pdf",
                    ImagePath = "reminders-of-him.jpg"
                },
                new BookModel
                {
                    ID = 10,
                    Title = "Twisted Love",
                    AuthorID = 9,
                    Description = "Twisted Love - Twisted (Paperback) A scintillating romance about a cold-hearted man driven by vengeance whose heart starts to melt when he is forced to look after his best friend's sister, Twisted Love is essential reading for all fans of enemies-to-lovers stories\r\n",
                    GenreID = 2,
                    BookPath = "Twisted-Love-Ebook.pdf",
                    ImagePath = "twisted-love.jpeg"
                },
                new BookModel
                {
                    ID = 11,
                    Title = "Ugly Love",
                    AuthorID = 8,
                    Description = "Ugly Love is one of Colleen Hoover's most noteworthy releases. This story follows Tate, a woman who falls for a distraught and reticent man named Miles. When these two souls meet, their connection is undeniable. However, Miles is a broken man and he cannot offer Tate anything other than a physical relationship\r\n",
                    GenreID = 2,
                    BookPath = "PDFORALL.COM-Ugly Love by Colleen Hoover.pdf",
                    ImagePath = "ugly love.jpg"
                },
                new BookModel
                {
                    ID = 12,
                    Title = "Verity",
                    AuthorID = 8,
                    Description = "Verity is mainly about three people - struggling author Lowen Ashleigh, a man called Jeremy Crawford, and Jeremy's wife, Verity, who was recently left incapacitated by a car accident. Verity is a successful writer, but she is no longer able to continue her bestselling series\r\n",
                    GenreID = 2,
                    BookPath = "Verity-By-Colleen-Hoover.pdf",
                    ImagePath = "verity.jpg"
                },
                     new BookModel
                {
                    ID = 13,
                    Title = "Twenty Thousand Leagues Under the Sea",
                    AuthorID = 10,
                    Description = "Twenty Thousand Leagues Under the Sea tells the story of three men who go to sea in search of a giant whale. They are taken prisoner on board the world's first submarine the Nautilus. The Nautilus travels through the world's seas. The men see amazing deep-sea creatures, and they travel to remote islands.\r\n",
                    GenreID = 3,
                    BookPath = "2000-leagues-under-the-sea.pdf",
                    ImagePath = "2000-leagues-under-the-sea.jpeg"
                },  
                new BookModel
                {
                    ID = 14,
                    Title = "Hucklebrerry Finn",
                    AuthorID = 11,
                    Description = "Mark Twain's classic The Adventures of Huckleberry Finn (1884) is told from the point of view of Huck Finn, a barely literate teen who fakes his own death to escape his abusive, drunken father. He encounters a runaway slave named Jim, and the two embark on a raft journey down the Mississippi River.\r\n",
                    GenreID = 3,
                    BookPath = "adventures-of-huckleberry-finn.pdf",
                    ImagePath = "adventures-of-huckleberry-finn.jfif"
                },
                new BookModel
                {
                    ID = 15,
                    Title = "Bronze Magic",
                    AuthorID = 12,
                    Description = "Bronze Magic is a feel-good fantasy tale in the tradition pre-dating the horror and thriller fusions that have infiltrated the genre. Betrayed by his older brother after beating him in a magic tournament, Prince Tarkyn is condemned to prison for no good reason.\r\n",
                    GenreID = 3,
                    BookPath = "bronze-magic.pdf",
                    ImagePath = "bronze-magic.jpg"
                },
                new BookModel
                {
                    ID = 16,
                    Title = "Fire and Water ",
                    AuthorID = 13,
                    Description = "Fire and Water is the powerful true story of a woman's transformational journey working with the forces of nature. She loves the elements of nature and is a firefighter who faces many challenges not only on the job, but in her daily life.\r\n",
                    GenreID = 3,
                    BookPath = "fire-water.pdf",
                    ImagePath = "fire-water.jpg"
                },
                new BookModel
                {
                    ID = 17,
                    Title = "in the heart of the sea",
                    AuthorID = 14,
                    Description = "A recounting of a New England whaling ship's sinking by a giant whale in 1820, an experience that later inspired the great novel Moby-Dick. In the winter of 1820, the New England whaling ship Essex was assaulted by something no one could believe: a whale of mammoth size and will, and an almost human sense of vengeance.\r\n",
                    GenreID = 3,
                    BookPath = "in the heart of the sea.pdf",
                    ImagePath = "in the heart of the sea.jpg"
                },
                new BookModel
                {
                    ID = 18,
                    Title = "Induction",
                    AuthorID = 15,
                    Description = "Induction is a story about prejudice, species, racial and gender persecution. A bitterness that goes back through multiple family lines and is growing through the next generation. T. K. Eldridge does a great job making a controversial topic easy to read by developing her characters into such relatable people\r\n",
                    GenreID = 3,
                    BookPath = "induction.pdf",
                    ImagePath = "induction.jpg"
                }
                ) ;
            modelBuilder.Entity<GenreModel>().HasData(
                new GenreModel
                {
                    GenreID = 1,
                    Name = "Engineering Books"
                },
                new GenreModel
                {
                    GenreID = 2,
                    Name = "Romantic Books"
                },
                new GenreModel
                {
                    GenreID = 3,
                    Name = "Adventure Books"
                }
                );


            modelBuilder.Entity<AdminModel>().HasData(
                new AdminModel
                {
                    ID = 1,
                    Name = "Hamza Hawasheen",
                    Email = "Hamza123123@gmail.com",
                    Password = "123123"
                },
                new AdminModel
                {
                    ID = 2,
                    Name = "Yousef Khalil",
                    Email = "Yousef123@gmail.com",
                    Password = "12345"
                },
                new AdminModel
                {
                    ID = 3,
                    Name = "Mohammad Yahya",
                    Email = "Mohammad123@gmail.com",
                    Password = "54321"
                }
                );
            modelBuilder.Entity<AuthorModel>().HasData(
                new AuthorModel
                {
                    AuthorID = 1,
                    Name = "Morris Mano"
                },

                new AuthorModel
                {
                    AuthorID = 2,
                    Name = "Thomas Floyd"
                },

               new AuthorModel
               {
                   AuthorID = 3,
                   Name = "Muhammad Mazidi"
               },
                new AuthorModel
                {
                    AuthorID = 4,
                    Name = "Rap Payne"
                },
                 new AuthorModel
                 {
                     AuthorID = 5,
                     Name = "Atul Godse"
                 },
                  new AuthorModel
                  {
                      AuthorID = 6,
                      Name = "Ramez Elmasri"
                  },
                  new AuthorModel
                  {
                      AuthorID = 7,
                      Name = "Emily Henry"
                  },
                  new AuthorModel
                  {
                      AuthorID = 8,
                      Name = "Colleen Hoover"
                  },
                  new AuthorModel
                  {
                      AuthorID = 9,
                      Name = "Ana Huang"
                  },
                  new AuthorModel
                  {
                      AuthorID = 10,
                      Name = "Jules Verne"
                  },
                  new AuthorModel
                  {
                      AuthorID = 11,
                      Name = "Mark Twain"
                  },
                  new AuthorModel
                  {
                      AuthorID = 12,
                      Name = "Jennifer Ealey"
                  },
                  new AuthorModel
                  {
                      AuthorID = 13,
                      Name = "Bobbi Schemerhorn"
                  },
                  new AuthorModel
                  {
                      AuthorID = 14,
                      Name = "Nathaniel Philbrick"
                  },
                  new AuthorModel
                  {
                      AuthorID = 15,
                      Name = "T.K. Eldridge"
                  }
                );
            modelBuilder.Entity<UserModel>().HasData(
               new UserModel
               {
                   Email = "Yousef1231230@gmail.com",
                   Password = "123"
               },
               new UserModel
               {
                   Email = "Yousef1231231@gmail.com",
                   Password = "1234"
               },
               new UserModel
               {
                   Email = "Yousef1231232@gmail.com",
                   Password = "12345"
               },
               new UserModel
               {
                   Email = "Yousef1231233@gmail.com",
                   Password = "123456"
               },
               new UserModel
               {
                   Email = "Yousef1231234@gmail.com",
                   Password = "1234567"
               },
               new UserModel
               {
                   Email = "Yousef1231235@gmail.com",
                   Password = "12345678"
               },
               new UserModel
               {
                   Email = "Yousef1231236@gmail.com",
                   Password = "123456789"
               }
               );
        }

        internal AdminModel Find(string? adminEmail)
        {
            throw new NotImplementedException();
        }
    }
}
