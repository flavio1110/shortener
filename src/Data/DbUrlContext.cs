using System;
using Microsoft.EntityFrameworkCore;

namespace Shortener.Web.Data
{
    public class DbUrlContext : DbContext
    {
        public DbUrlContext(DbContextOptions<DbUrlContext> options)
            : base(options)
        { }
        public DbSet<LongUrl> LongUrls { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<LongUrl>()
                .ToTable("LongUrl");
 
            base.OnModelCreating(builder);
        }
    }
}