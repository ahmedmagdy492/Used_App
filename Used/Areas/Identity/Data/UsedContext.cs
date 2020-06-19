using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Used.Models;

namespace Used.Data
{
    public class UsedContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Images> Images { get; set; }
        public DbSet<Messages> Messages { get; set; }
        public DbSet<ConnectedUser> ConnectedUsers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProdImgs> ProdImgs { get; set; }

        public UsedContext(DbContextOptions<UsedContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
