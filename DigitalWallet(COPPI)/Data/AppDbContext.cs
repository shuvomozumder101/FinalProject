using DigitalWallet_COPPI_.Models;
using DigitalWallet_COPPI_.Models.Message;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalWallet_COPPI_.Data
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Message>()
                .HasNoKey();
        }
        public DbSet<Registration> Registrations { get; set; }
        public DbSet<Login> Logins { get; set; }
        public DbSet<Message> Messages { get; set; }

    }
}
