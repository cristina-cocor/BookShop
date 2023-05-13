using Microsoft.EntityFrameworkCore;
using ProiectFinal.Models;
using System;
using System.Collections.Generic;
//using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;

namespace ProiectFinal.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options): base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author_Book>().HasKey(ab => new
            {
                ab.AuthorId,
                ab.BookId
            });

            modelBuilder.Entity<Author_Book>().HasOne(b => b.Book).WithMany(ab => ab.Author_Books).HasForeignKey(b => b.BookId);

            modelBuilder.Entity<Author_Book>().HasOne(b => b.Author).WithMany(ab => ab.Author_Books).HasForeignKey(b => b.AuthorId);

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author_Book> Authors_Books { get; set; }
        public DbSet<PublishingHouse> PublishingHouses { get; set; }


    }
}
