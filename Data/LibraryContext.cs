using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NETDLab5CA.Models;
using Microsoft.EntityFrameworkCore;

namespace NETDLab5CA.Data
{
    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions<LibraryContext> options) : base(options)
        {
        }

        // Add Book, Hold and Client model into table in database
        public DbSet<Book> Books { get; set; }
        public DbSet<Hold> Holds { get; set; }
        public DbSet<Client> Clients { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().ToTable("Book");
            modelBuilder.Entity<Hold>().ToTable("Hold");
            modelBuilder.Entity<Client>().ToTable("Client");
        }
    }
}
