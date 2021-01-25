using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalWallet_COPPI_.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
      
        public DbSet<DigitalWallet_COPPI_.Models.Registration> Registration { get; set; }
        public DbSet<DigitalWallet_COPPI_.Models.Login> Logins { get; set; }
    }
}
