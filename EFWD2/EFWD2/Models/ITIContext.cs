using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace EFWD2.Models
{
    public class ITIContext : DbContext
    {
        public virtual DbSet<post> Posts { get; set; }
        public virtual DbSet<auther> Authers { get; set; }
        public virtual DbSet<catigory> Catigories { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			// Configure the relationships between entities here

			// Define the relationship between Auther and Post
			modelBuilder.Entity<auther>()
				.HasMany(a => a.Posts)
				.WithOne(p => p.Auther)
				.HasForeignKey(p => p.autherId);

			// Define the relationship between Catigory and Post
			modelBuilder.Entity<catigory>()
				.HasMany(c => c.Posts)
				.WithOne(p => p.Catigory)
				.HasForeignKey(p => p.catId);
		}
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer("Data Source=.;Initial Catalog=Facebook;Integrated Security=True;TrustServerCertificate=True");
        }

    }
}
