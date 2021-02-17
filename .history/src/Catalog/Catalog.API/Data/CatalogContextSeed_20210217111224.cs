namespace Catalog.API.Data
{
    public class CatalogContextSeed
    {
        public static void SeedDate(IMongoCollection<Product> collection)
        {
            bool existingProduct = collection.Find(p => true).Any();
        }
    }
}