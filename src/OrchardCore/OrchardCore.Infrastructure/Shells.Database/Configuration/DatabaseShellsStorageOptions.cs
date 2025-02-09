using OrchardCore.Data;

namespace OrchardCore.Shells.Database.Configuration
{
    public class DatabaseShellsStorageOptions
    {
        public bool MigrateFromFiles { get; set; }
        public DatabaseProviderName DatabaseProvider { get; set; }
        public string ConnectionString { get; set; }
        public string TablePrefix { get; set; }
    }
}
