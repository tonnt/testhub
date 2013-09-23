using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testhub.Models
{
    public class MyDbContext : DbContext
    {

        public MyDbContext()
            : base()
        {
        }

        public MyDbContext(DbConnection connection)
            : base(connection, true)
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            /*-------------------------------------------------------------
            ColumnTypeCasingConvention should be removed for dotConnect for Oracle.
            This option is obligatory only for SqlClient.
            Turning off ColumnTypeCasingConvention isn't necessary
            for  dotConnect for MySQL, PostgreSQL, and SQLite.
            -------------------------------------------------------------*/

            modelBuilder.Conventions
              .Remove<System.Data.Entity.ModelConfiguration.Conventions
                .ColumnTypeCasingConvention>();

            /*-------------------------------------------------------------
            If you don't want to create and use EdmMetadata table
            for monitoring the correspondence
            between the current model and table structure
            created in a database, then turn off IncludeMetadataConvention:
            -------------------------------------------------------------*/

            modelBuilder.Conventions
              .Remove<System.Data.Entity.Infrastructure.IncludeMetadataConvention>();

            /*-------------------------------------------------------------
            In the sample above we have defined autoincrement columns in the primary key
            and non-nullable columns using DataAnnotation attributes.
            Similarly, the same can be done with Fluent mapping
            -------------------------------------------------------------*/

            //modelBuilder.Entity<Product>().HasKey(p => p.ProductID);
            //modelBuilder.Entity<Product>().Property(p => p.ProductID)
            //    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            //modelBuilder.Entity<Product>().Property(p => p.ProductName)
            //    .IsRequired()
            //    .HasMaxLength(50);
            //modelBuilder.Entity<ProductCategory>().HasKey(p => p.CategoryID);
            //modelBuilder.Entity<ProductCategory>().Property(p => p.CategoryID)
            //    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            //modelBuilder.Entity<ProductCategory>().Property(p => p.CategoryName)
            //    .IsRequired()
            //    .HasMaxLength(20);
            //modelBuilder.Entity<Product>().ToTable("Product", "TEST");
            //modelBuilder.Entity<ProductCategory>().ToTable("ProductCategory", "TEST");

            //-------------------------------------------------------------//
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
    }
}
