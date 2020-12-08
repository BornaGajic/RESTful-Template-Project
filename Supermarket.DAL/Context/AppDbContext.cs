using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket.API.Model;

namespace Supermarket.DAL.Context
{
	// DbContext -> maps models to database tables
	public class AppDbContext : DbContext
	{
		public DbSet<Category> Categories { get; set; }
		public DbSet<Product> Products { get; set; }

		public AppDbContext () : base("SupermarketDBConnectionString")
		{
		}

		protected override void OnModelCreating (DbModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.Entity<Category>().ToTable("Categories");
			modelBuilder.Entity<Category>().HasKey(c => c.Id);
			modelBuilder.Entity<Category>().Property(prop => prop.Id).IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
			modelBuilder.Entity<Category>().Property(prop => prop.Name).IsRequired().HasMaxLength(30);
			modelBuilder.Entity<Category>().HasMany(c => c.Products).WithRequired(p => p.Category).HasForeignKey(p => p.CategoryId);

			modelBuilder.Entity<Product>().ToTable("Products");
			modelBuilder.Entity<Product>().HasKey(p => p.Id);
			modelBuilder.Entity<Product>().Property(prop => prop.Id).IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
			modelBuilder.Entity<Product>().Property(prop => prop.Name).IsRequired().HasMaxLength(50);
			modelBuilder.Entity<Product>().Property(prop => prop.QuantityInPackage).IsRequired();
			modelBuilder.Entity<Product>().Property(prop => prop.UnitOfMeasurement).IsRequired();
		}
	}
}
