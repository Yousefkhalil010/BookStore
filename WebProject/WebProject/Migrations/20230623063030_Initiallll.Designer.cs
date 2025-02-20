﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebProject.Models;

#nullable disable

namespace WebProject.Migrations
{
    [DbContext(typeof(BookStoreContextModel))]
    [Migration("20230623063030_Initiallll")]
    partial class Initiallll
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebProject.Models.AdminModel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Admin");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Email = "Hamza123123@gmail.com",
                            Name = "Hamza",
                            Password = "123123"
                        });
                });

            modelBuilder.Entity("WebProject.Models.AuthorModel", b =>
                {
                    b.Property<int>("AuthorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AuthorID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AuthorID");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            AuthorID = 1,
                            Name = "Morris Mano"
                        },
                        new
                        {
                            AuthorID = 2,
                            Name = "Thomas Floyd"
                        },
                        new
                        {
                            AuthorID = 3,
                            Name = "Muhammad Mazidi"
                        },
                        new
                        {
                            AuthorID = 4,
                            Name = "Rap Payne"
                        },
                        new
                        {
                            AuthorID = 5,
                            Name = "Atul Godse"
                        },
                        new
                        {
                            AuthorID = 6,
                            Name = "Ramez Elmasri"
                        },
                        new
                        {
                            AuthorID = 7,
                            Name = "Emily Henry"
                        },
                        new
                        {
                            AuthorID = 8,
                            Name = "Colleen Hoover"
                        },
                        new
                        {
                            AuthorID = 9,
                            Name = "Ana Huang"
                        },
                        new
                        {
                            AuthorID = 10,
                            Name = "Jules Verne"
                        },
                        new
                        {
                            AuthorID = 11,
                            Name = "Mark Twain"
                        },
                        new
                        {
                            AuthorID = 12,
                            Name = "Jennifer Ealey"
                        },
                        new
                        {
                            AuthorID = 13,
                            Name = "Bobbi Schemerhorn"
                        },
                        new
                        {
                            AuthorID = 14,
                            Name = "Nathaniel Philbrick"
                        },
                        new
                        {
                            AuthorID = 15,
                            Name = "T.K. Eldridge"
                        });
                });

            modelBuilder.Entity("WebProject.Models.BookModel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("AuthorID")
                        .HasColumnType("int");

                    b.Property<string>("BookPath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GenreID")
                        .HasColumnType("int");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("AuthorID");

                    b.HasIndex("GenreID");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            AuthorID = 1,
                            BookPath = "Digital Design.pdf",
                            Description = "Digital design material covers principles and concepts related to circuits, logic gates, and system architecture in digital systems",
                            GenreID = 1,
                            ImagePath = "digital.jpg",
                            Title = "Digital design"
                        },
                        new
                        {
                            ID = 2,
                            AuthorID = 2,
                            BookPath = "Electronics.pdf",
                            Description = "Electronics material encompasses components and technologies used in the design, analysis, and implementation of electronic circuits and systems\r\n",
                            GenreID = 1,
                            ImagePath = "electronics.jpg",
                            Title = "Electronics"
                        },
                        new
                        {
                            ID = 3,
                            AuthorID = 3,
                            BookPath = "PIC Microcontroller and Embedded Systems.pdf",
                            Description = "Embedded system material refers to the hardware components and resources used in the development of embedded systems\r\n",
                            GenreID = 1,
                            ImagePath = "embdedd.jpg",
                            Title = "Embedded system"
                        },
                        new
                        {
                            ID = 4,
                            AuthorID = 4,
                            BookPath = "Beginning App development with flutter.pdf",
                            Description = "Flutter Material is a UI framework that provides pre-designed components for building visually appealing cross-platform apps\r\n",
                            GenreID = 1,
                            ImagePath = "flutter.jpg",
                            Title = "Flutter"
                        },
                        new
                        {
                            ID = 5,
                            AuthorID = 5,
                            BookPath = "microprocessorsandinterfacing-d-151020182302-lva1-app6892.pdf",
                            Description = "Microprocessor material focuses on the study of integrated circuits that function as the central processing unit in computer systems\r\n",
                            GenreID = 1,
                            ImagePath = "microprocessor.jpg",
                            Title = "Microprocessor"
                        },
                        new
                        {
                            ID = 6,
                            AuthorID = 6,
                            BookPath = "Data Base.pdf",
                            Description = "Database material involves the study of structured collections of data and their management, organization, and retrieval methods\r\n",
                            GenreID = 1,
                            ImagePath = "data base.jpg",
                            Title = "Database"
                        },
                        new
                        {
                            ID = 7,
                            AuthorID = 7,
                            BookPath = "Book_Lovers_by_Emily_Henry.pdf",
                            Description = "Nora has been through enough break-ups to know she's the one men date before finding their happy-ever-after. Nora's sister, Libby, persuades her to swap her city desk for a month's break in Sunshine Falls, in the hope she might enjoy a holiday romance\r\n",
                            GenreID = 2,
                            ImagePath = "book lovers.jpg",
                            Title = "Book Lovers"
                        },
                        new
                        {
                            ID = 8,
                            AuthorID = 7,
                            BookPath = "Happy Place (Emily Henry) (Books-Here).pdf",
                            Description = "Sabrina, Cleo, Kimmy, and Parth are Harriet and Wyn's closest friends in the world, the family they chose, and their ride-or-die besties. Afraid to change the dynamic between the group, and ruin the last weekend at their beloved vacation home, they choose to keep their parting a secret\r\n",
                            GenreID = 2,
                            ImagePath = "happy place.jpg",
                            Title = "Happy Place"
                        },
                        new
                        {
                            ID = 9,
                            AuthorID = 8,
                            BookPath = "Reminders of Him (Colleen Hoover) (books-here.com).pdf",
                            Description = "A troubled young mother yearns for a shot at redemption in this heartbreaking yet hopeful story from #1 New York Times bestselling author Colleen Hoover. After serving five years in prison for a tragic mistake, Kenna Rowan returns to the town where it all went wrong, hoping to reunite with her four-year-old daughter\r\n",
                            GenreID = 2,
                            ImagePath = "reminders-of-him.jpg",
                            Title = "reminders of him"
                        },
                        new
                        {
                            ID = 10,
                            AuthorID = 9,
                            BookPath = "Twisted-Love-Ebook.pdf",
                            Description = "Twisted Love - Twisted (Paperback) A scintillating romance about a cold-hearted man driven by vengeance whose heart starts to melt when he is forced to look after his best friend's sister, Twisted Love is essential reading for all fans of enemies-to-lovers stories\r\n",
                            GenreID = 2,
                            ImagePath = "twisted-love.jpeg",
                            Title = "Twisted Love"
                        },
                        new
                        {
                            ID = 11,
                            AuthorID = 8,
                            BookPath = "PDFORALL.COM-Ugly Love by Colleen Hoover.pdf",
                            Description = "Ugly Love is one of Colleen Hoover's most noteworthy releases. This story follows Tate, a woman who falls for a distraught and reticent man named Miles. When these two souls meet, their connection is undeniable. However, Miles is a broken man and he cannot offer Tate anything other than a physical relationship\r\n",
                            GenreID = 2,
                            ImagePath = "ugly love.jpg",
                            Title = "Ugly Love"
                        },
                        new
                        {
                            ID = 12,
                            AuthorID = 8,
                            BookPath = "Verity-By-Colleen-Hoover.pdf",
                            Description = "Verity is mainly about three people - struggling author Lowen Ashleigh, a man called Jeremy Crawford, and Jeremy's wife, Verity, who was recently left incapacitated by a car accident. Verity is a successful writer, but she is no longer able to continue her bestselling series\r\n",
                            GenreID = 2,
                            ImagePath = "verity.jpg",
                            Title = "Verity"
                        },
                        new
                        {
                            ID = 13,
                            AuthorID = 10,
                            BookPath = "2000-leagues-under-the-sea.pdf",
                            Description = "Twenty Thousand Leagues Under the Sea tells the story of three men who go to sea in search of a giant whale. They are taken prisoner on board the world's first submarine the Nautilus. The Nautilus travels through the world's seas. The men see amazing deep-sea creatures, and they travel to remote islands.\r\n",
                            GenreID = 3,
                            ImagePath = "2000-leagues-under-the-sea.jpeg",
                            Title = "Twenty Thousand Leagues Under the Sea"
                        },
                        new
                        {
                            ID = 14,
                            AuthorID = 11,
                            BookPath = "adventures-of-huckleberry-finn.pdf",
                            Description = "Mark Twain's classic The Adventures of Huckleberry Finn (1884) is told from the point of view of Huck Finn, a barely literate teen who fakes his own death to escape his abusive, drunken father. He encounters a runaway slave named Jim, and the two embark on a raft journey down the Mississippi River.\r\n",
                            GenreID = 3,
                            ImagePath = "adventures-of-huckleberry-finn.jfif",
                            Title = "Hucklebrerry Finn"
                        },
                        new
                        {
                            ID = 15,
                            AuthorID = 12,
                            BookPath = "bronze-magic.pdf",
                            Description = "Bronze Magic is a feel-good fantasy tale in the tradition pre-dating the horror and thriller fusions that have infiltrated the genre. Betrayed by his older brother after beating him in a magic tournament, Prince Tarkyn is condemned to prison for no good reason.\r\n",
                            GenreID = 3,
                            ImagePath = "bronze-magic.jpg",
                            Title = "Bronze Magic"
                        },
                        new
                        {
                            ID = 16,
                            AuthorID = 13,
                            BookPath = "fire-water.pdf",
                            Description = "Fire and Water is the powerful true story of a woman's transformational journey working with the forces of nature. She loves the elements of nature and is a firefighter who faces many challenges not only on the job, but in her daily life.\r\n",
                            GenreID = 3,
                            ImagePath = "fire-water.jpg",
                            Title = "Fire and Water "
                        },
                        new
                        {
                            ID = 17,
                            AuthorID = 14,
                            BookPath = "in the heart of the sea.pdf",
                            Description = "A recounting of a New England whaling ship's sinking by a giant whale in 1820, an experience that later inspired the great novel Moby-Dick. In the winter of 1820, the New England whaling ship Essex was assaulted by something no one could believe: a whale of mammoth size and will, and an almost human sense of vengeance.\r\n",
                            GenreID = 3,
                            ImagePath = "in the heart of the sea.jpg",
                            Title = "in the heart of the sea"
                        },
                        new
                        {
                            ID = 18,
                            AuthorID = 15,
                            BookPath = "induction.pdf",
                            Description = "Induction is a story about prejudice, species, racial and gender persecution. A bitterness that goes back through multiple family lines and is growing through the next generation. T. K. Eldridge does a great job making a controversial topic easy to read by developing her characters into such relatable people\r\n",
                            GenreID = 3,
                            ImagePath = "induction.jpg",
                            Title = "Induction"
                        });
                });

            modelBuilder.Entity("WebProject.Models.GenreModel", b =>
                {
                    b.Property<int>("GenreID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GenreID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GenreID");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            GenreID = 1,
                            Name = "Engineering Books"
                        },
                        new
                        {
                            GenreID = 2,
                            Name = "Romantic Books"
                        },
                        new
                        {
                            GenreID = 3,
                            Name = "Adventure Books"
                        });
                });

            modelBuilder.Entity("WebProject.Models.UserModel", b =>
                {
                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Email");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            Email = "Yousef1231230@gmail.com",
                            Password = "123"
                        },
                        new
                        {
                            Email = "Yousef1231231@gmail.com",
                            Password = "1234"
                        },
                        new
                        {
                            Email = "Yousef1231232@gmail.com",
                            Password = "12345"
                        },
                        new
                        {
                            Email = "Yousef1231233@gmail.com",
                            Password = "123456"
                        },
                        new
                        {
                            Email = "Yousef1231234@gmail.com",
                            Password = "1234567"
                        },
                        new
                        {
                            Email = "Yousef1231235@gmail.com",
                            Password = "12345678"
                        },
                        new
                        {
                            Email = "Yousef1231236@gmail.com",
                            Password = "123456789"
                        });
                });

            modelBuilder.Entity("WebProject.Models.BookModel", b =>
                {
                    b.HasOne("WebProject.Models.AuthorModel", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebProject.Models.GenreModel", "Genre")
                        .WithMany()
                        .HasForeignKey("GenreID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Genre");
                });
#pragma warning restore 612, 618
        }
    }
}
