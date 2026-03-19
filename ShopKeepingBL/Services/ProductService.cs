using ShopKeepingBL.Repositories;
using ShopKeepingModels.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopKeepingBL.Services
{
    public interface IProductService
    {
        Task<List<ProductModel>> GetProducts();
    }
    public class ProductService(IProductRepository productRepository) : IProductService
    {
        public  Task<List<ProductModel>> GetProducts()
        {
            return productRepository.GetProducts();
        }
    }
}
