namespace Catalog.API.Data.Interfaces
{
    public interface ICatalogContext
    {
        IMongoDBCollection<Product> Products { get; }
    }
}