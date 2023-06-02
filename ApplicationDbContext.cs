using LV5_Flyaway.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LV5_Flyaway.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Let> Let { get; set; }
        public DbSet<putnici> putnici { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Let>().ToTable("Let");
            modelBuilder.Entity<putnici>().ToTable("putnici");
            
            base.OnModelCreating(modelBuilder);
        }

    }
}
