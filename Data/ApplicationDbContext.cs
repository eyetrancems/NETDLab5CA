using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

//import the model
using NETDLab5CA.Models;

namespace NETDLab5CA.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Add Book, Hold and Client model into table in database
        public DbSet<Book> Books { get; set; }
        public DbSet<Hold> Holds { get; set; }
        public DbSet<Client> Clients { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Book>().ToTable("Book");
            modelBuilder.Entity<Hold>().ToTable("Hold");
            modelBuilder.Entity<Client>().ToTable("Client");
        }
    }
}
