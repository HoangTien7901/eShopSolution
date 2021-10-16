using eShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Data.EF
{
    public class EShopDBContext : DbContext
    {
        public EShopDBContext(DbContextOptions options) : base(options)
        {
        }        

        DbSet<Product> Products { get; set; }
        DbSet<Category> Categories { get; set; }
        DbSet<Cart> Carts { get; set; }
        DbSet<CategoryTranslation> CategoryTranslations { get; set; }
        DbSet<Transaction> Transactions { get; set; }
        DbSet<Order> Orders { get; set; }
        DbSet<OrderDetail> OrderDetails { get; set; }
        DbSet<ProductTranslation> ProductTranslations { get; set; }
        DbSet<Promotion> Promotions { get; set; }
        DbSet<Language> Languages { get; set; }
        DbSet<Contact> Contacts { get; set; }
        DbSet<AppConfig> AppConfigs { get; set; }





    }
}
