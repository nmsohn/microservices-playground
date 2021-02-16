namespace Catalog.API.Settings
{
    public class CatalogDatabaseSettings : ICatalogDatabaseSettings
    {
        public string CollectionName {get; set;}
        public string ConnectionString {get; set;}
        public string DatabaseNAme {get; set;}
    }
}