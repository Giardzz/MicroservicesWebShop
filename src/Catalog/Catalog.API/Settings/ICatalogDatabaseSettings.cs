
namespace Catalog.API.Settings
{
    public interface ICatalogDatabaseSettings
    {
        string ConnectionString { get; set; }
        string CollectionName { get; set; }
        string DatabaseName { get; set; }
    }
}
