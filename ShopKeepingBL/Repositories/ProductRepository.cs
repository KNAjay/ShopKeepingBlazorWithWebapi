using Microsoft.EntityFrameworkCore;
using ShopKeepingDatabase.Data;
using ShopKeepingModels.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopKeepingBL.Repositories
{
    public interface IProductRepository
    {
        Task<List<ProductModel>> GetProducts();
    }
    public class ProductRepository(AppDBContext appDB ) : IProductRepository
    {
        public Task<List<ProductModel>> GetProducts()
        {
            return appDB.Products.ToListAsync();
        }
    }
}
