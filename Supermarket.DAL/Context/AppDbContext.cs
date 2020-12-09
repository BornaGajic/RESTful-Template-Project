using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket.DAL.EntityModels;
using System.ComponentModel.DataAnnotations.Schema;

namespace Supermarket.DAL.Context
{
	// DbContext -> maps models to database tables
	public class AppDbContext : DbContext
	{
		public DbSet<CategoryEntity> Categories { get; set; }
		public DbSet<ProductEntity> Products { get; set; }

		public AppDbContext () : base("SupermarketDBConnectionString")
		{
		}

		protected override void OnModelCreating (DbModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.Entity<CategoryEntity>().ToTable("Categories");
			modelBuilder.Entity<CategoryEntity>().HasKey(c => c.Id);
			modelBuilder.Entity<CategoryEntity>().Property(prop => prop.Id).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
			modelBuilder.Entity<CategoryEntity>().Property(prop => prop.Name).IsRequired().HasMaxLength(30);
			modelBuilder.Entity<CategoryEntity>().HasMany(c => c.Products).WithRequired(p => p.CategoryEntity).HasForeignKey(p => p.CategoryId);

			modelBuilder.Entity<ProductEntity>().ToTable("Products");
			modelBuilder.Entity<ProductEntity>().HasKey(p => p.Id);
			modelBuilder.Entity<ProductEntity>().Property(prop => prop.Id).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
			modelBuilder.Entity<ProductEntity>().Property(prop => prop.Name).IsRequired().HasMaxLength(50);
			modelBuilder.Entity<ProductEntity>().Property(prop => prop.QuantityInPackage).IsRequired();
			modelBuilder.Entity<ProductEntity>().Property(prop => prop.UnitOfMeasurement).IsRequired();
		}
	}
}
