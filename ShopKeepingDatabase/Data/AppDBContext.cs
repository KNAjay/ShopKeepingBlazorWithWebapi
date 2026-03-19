using Microsoft.EntityFrameworkCore;
using ShopKeepingModels.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopKeepingDatabase.Data
{
    public class AppDBContext: DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options):base(options)
        {
            Database.EnsureCreated();
            
        }
        public DbSet<ProductModel> Products { get; set; }
    }
}
