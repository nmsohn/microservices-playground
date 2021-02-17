using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Catalog.API.Data.Interfaces;
using Catalog.API.Entities;
using Catalog.API.Repositories.Interfaces;
using MongoDB.Driver;

namespace Catalog.API.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ICatalogContext _context;

        public ProductRepository(ICatalogContext catalogContext)
        {
            this._context = catalogContext ?? throw new ArgumentNullException(nameof(catalogContext));
        }

        public async Task<Product> GetProduct(string id)
        {
            return await _context.Products.Find(p => p.Id == id).FirstOrDefaultAsync();
        }
        public async Task<IEnumerable<Product>> GetProducts()
        {
            return await _context.Products.Find(p => true).ToListAsync();
        }
        public async Task<IEnumerable<Product>> GetProductByName(string name)
        {
            return await _context.Products.Find(p => p.Name == name).ToListAsync();
        }

        public async Task<IEnumerable<Product>> GetProductByCategory(string category)
        {
            return await _context.Products.Find(p => p.Category == category).ToListAsync();
        }

        public async Task Create(Product product)
        {
            await _context.Products.InsertOneAsync(product);
        }

        public Task<bool> Update(Product product)
        {
            throw new System.NotImplementedException();
        }
        public Task<bool> Delete(string id)
        {
            throw new System.NotImplementedException();
        }
    }
}