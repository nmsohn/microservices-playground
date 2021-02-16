namespace Catalog.API.Settings
{
    public interface ICatalogDatabaseSettings
    {
        string CollectionName {get; set;}
        string ConnectionString {get; set;}
        string DatabaseNAme {get; set;}
    }
}