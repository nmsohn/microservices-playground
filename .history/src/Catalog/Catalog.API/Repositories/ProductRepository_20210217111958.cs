using System.Collections.Generic;
using System.Threading.Tasks;
using Catalog.API.Entities;
using Catalog.API.Repositories.Interfaces;

namespace Catalog.API.Repositories
{
    public class PRoductRepository : IProductRepository
    {
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