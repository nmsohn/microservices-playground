using System;
using Catalog.API.Data.Interfaces;
using Catalog.API.Settings;
using MongoDB.Driver;

namespace Catalog.API.Data
{
    public class CatalogContext : ICatalogContext
    {
        private readonly ICatalogDatabaseSettings settings;

        public CatalogContext(ICatalogDatabaseSettings settings)
        {
            var client = new MongoClient();
        }
        public IMongoDBCollection<Product> Products => throw new NotImplementedException();
    }
}