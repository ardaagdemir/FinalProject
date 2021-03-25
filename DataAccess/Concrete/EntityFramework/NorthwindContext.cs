using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    //Context: Db tabloları ile proje classlarını bağlamak 
    public class NorthwindContext:DbContext //DbContext, entityFramework de bulunan bir base sınıftır
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //sql server connection method
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb; Database=Northwind; Trusted_Connection=true"); //trusted connection: kullanıcı adı ve şifre vermeden giriş
                                                                            //connection string 
        }

        //Product classını Products tablosuna eşle
        public DbSet<Product> Products { get; set; }

        
        public DbSet<Category> Categories { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Order> Orders { get; set; }
    }
}
