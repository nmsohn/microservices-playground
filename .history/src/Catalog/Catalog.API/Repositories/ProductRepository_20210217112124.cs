using System.Collections.Generic;
using System.Threading.Tasks;
using Catalog.API.Data.Interfaces;
using Catalog.API.Entities;
using Catalog.API.Repositories.Interfaces;

namespace Catalog.API.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ICatalogContext catalogContext;

        public ProductRepository(ICatalogContext catalogContext)
        {
            this.catalogContext = catalogContext ?? throw new ArgumentNullException(nameof(catalogContext));
        }
        public Task Create(Product product)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> Delete(string id)
        {
            throw new System.NotImplementedException();
        }

        public Task<Product> GetProduct(string id)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<Product>> GetProductByCategory(string category)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<Product>> GetProductByName(string name)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<Product>> GetProducts()
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> Update(Product product)
        {
            throw new System.NotImplementedException();
        }
    }
}