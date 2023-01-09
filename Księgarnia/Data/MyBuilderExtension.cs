using Księgarnia.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileSystemGlobbing;
using static System.Net.Mime.MediaTypeNames;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;
using System.Security.Policy;
using System.Xml.Linq;
using System;

namespace Księgarnia.Data
{
    public static class MyBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Category>().HasData(
               new Category()
               {
                   Id = 1,
                   Name = "Books"
               },
               new Category()
               {
                   Id = 2,
                   Name = "Products"
               }

               );


            modelBuilder.Entity<Article>().HasData(
                    new Article()
                    {
                        Id = 1,
                        Name = "Pen",
                        Price = 1.56,
                        CategoryId = 2,
                        FilePath = "/images/bic.jpg",
                        Amount = 50,
                        Detail = "Blue color pen.",
                        Producer = "Bic",
                        Author = null,
                        Publisher = null



                    },
                    new Article()
                    {
                        Id = 2,
                        Name = "Rubber",
                        Price = 2.22,
                        CategoryId = 2,
                        FilePath = "/images/rubb.jpg",
                        Amount = 50,
                        Detail = "White rubber",
                        Producer = "Bic",
                        Author = null,
                        Publisher = null
                    },
                    new Article()
                    {
                        Id = 3,
                        Name = "Colorful papers",
                        Price = 10.22,
                        CategoryId = 2,
                        FilePath = "/images/pap.jpg",
                        Amount = 40,
                        Detail = "Colorful papers",
                        Producer = "Bic",
                        Author = null,
                        Publisher = null


                    },
                    new Article()
                    {
                        Id = 4,
                        Name = "Christmas cards",
                        Price = 10.99,
                        CategoryId = 2,
                        FilePath = "/images/kartka.jpg",
                        Amount = 34,
                        Detail = "Christmas cards to make your close ones feel special.",
                        Producer = "MyCards",
                        Author = null,
                        Publisher = null

                    },
                    new Article()
                    {
                        Id = 5,
                        Name = "1984",
                        Price = 39.99,
                        CategoryId = 1,
                        FilePath = "/images/rok.jpg",
                        Amount = 15,
                        Detail = "Dystopian social science fiction novel and cautionary tale by English writer George Orwell. It was published on 8 June 1949 by Secker & Warburg as Orwell's ninth and final book completed in his lifetime. Thematically, it centres on the consequences of totalitarianism, mass surveillance and repressive regimentation of people and behaviours within society.",
                        Producer = null,
                        Author = "George Orwell",
                        Publisher = "Secker & Warburg"

                    },
                    new Article()
                    {
                        Id = 6,
                        Name = "THE KARAMAZOV BROTHERS",
                        Price = 51.99,
                        CategoryId = 1,
                        FilePath = "/images/bro.jpg",
                        Amount = 16,
                        Detail = "Set in 19th-century Russia, The Brothers Karamazov is a passionate philosophical novel that enters deeply into questions of God, free will, and morality. It is a theological drama dealing with problems of faith, doubt, and reason in the context of a modernizing Russia, with a plot that revolves around the subject of patricide.",
                        Producer = null,
                        Author = "Fyodor Dostoevsky",
                        Publisher = "The Russian Messenger"

                    },
                    new Article()
                    {
                        Id = 7,
                        Name = "Snow White",
                        Price = 15.99,
                        CategoryId = 1,
                        FilePath = "/images/snow.jpg",
                        Amount = 24,
                        Detail = "The fairy tale features such elements as the magic mirror, the poisoned apple, the glass coffin, and the characters of the Evil Queen and the seven Dwarfs. ",
                        Producer = null,
                        Author = "Richard Holliss, Brian Sibley",
                        Publisher = "Egmont"

                    },
                    new Article()
                    {
                        Id = 8,
                        Name = "The last song",
                        Price = 31.07,
                        CategoryId = 1,
                        FilePath = "/images/thelask.jpg",
                        Amount = 25,
                        Detail = "A story about family, first loves and second chances.Ronnie was forced to spend the summer at her father's house in an isolated seaside town in North Carolina. For a rebellious girl, it's a hard test: used to the hustle and bustle of the big city and its nightclubs,she has to leave everything behind and face her father,whom she still feels sorry for after he left his family.Will this be Ronnie's worst vacation yet? Or will she meet someone who will change her life for good...?.",
                        Producer = null,
                        Author = "Nicolas Sparks",
                        Publisher = "Albartos"

                    },
                    new Article()
                    {
                        Id = 9,
                        Name = "Harry Potter and the philosopher's stone",
                        Price = 21.50,
                        CategoryId = 1,
                        FilePath = "/images/harry.jpg",
                        Amount = 33,
                        Detail = "What if the world of magic and spells really exists? Is it right next to us? Join the young wizard Harry Potter in an amazing alternate reality where anything is possible. Immerse yourself in the first book in the Harry Potter and the Philosopher's Stone series by J.K. Rowling.",
                        Producer = null,
                        Author = "J.K. Rowling" ,
                        Publisher = "Media Rodzina"

                    },

                    new Article()
                    {
                        Id = 10,
                        Name = "Twilight",
                        Price = 39.90,
                        CategoryId = 1,
                        FilePath = "/images/tw.jpg",
                        Amount = 35,
                        Detail = "Incredibly gripping story that keeps the reader in suspense until the very end. Its heroine, seventeen-year-old Isabella Swan, moves to a gloomy town in rainy Washington state and meets the mysterious, handsome Edward Cullen. The boy has superhuman abilities - he is irresistible, but also impossible to figure out. The girl tries to learn his dark secrets, but she does not realize that she is putting herself and her loved ones at risk. It turns out that she fell in love with a vampire...",
                        Producer = null,
                        Author = "Meyer Stephenie",
                        Publisher = "Dolnośląskie"

                    }

                    );

            modelBuilder.Entity<PaymentMethod>().HasData(
               new PaymentMethod()
               {
                   Id = 1,
                   Name = "Blik"
               },
               new PaymentMethod()
               {
                   Id = 2,
                   Name = "Card"
               },
               new PaymentMethod()
               {
                   Id = 3,
                   Name = "Transfer"
               }, 
               new PaymentMethod()
               {
                   Id = 4,
                   Name = "COD"
               }
               );

            modelBuilder.Entity<DeliveryMethod>().HasData(
               new DeliveryMethod()
               {
                   Id = 1,
                   Name = "Parcel Locker"
               },
               new DeliveryMethod()
               {
                   Id = 2,
                   Name = "DeliveryMan"
               }
               
               );

            modelBuilder.Entity<DocumentKind>().HasData(
               new DocumentKind()
               {
                   Id = 1,
                   Name = "Receipt"
               },
               new DocumentKind()
               {
                   Id = 2,
                   Name = "Invoice"
               }

               );

            modelBuilder.Entity<ParcelLocker>().HasData(
               new ParcelLocker()
               {
                   Id = 1,
                   Address = "ul. Wyszyńskiego 10 50-323 Wrocław",
                   

               },
               new ParcelLocker()
               {
                   Id = 2,
                   Address = "ul. Główna 30 50-323 Wrocław",

               },
               new ParcelLocker()
               {
                   Id = 3,
                   Address = "ul. Orzeszkowej 61 50-453 Wrocław",

               },
               new ParcelLocker()
               {
                   Id = 4,
                   Address = "ul. Pszenna 20 50-323 Wrocław",

               }, new ParcelLocker()
               {
                   Id = 5,
                   Address = "ul.Tęczowa 11 50-323 Wrocław",

               }

               );
        }
    }
}
