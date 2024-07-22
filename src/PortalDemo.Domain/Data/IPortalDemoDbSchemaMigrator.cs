using System.Threading.Tasks;

namespace PortalDemo.Data;

public interface IPortalDemoDbSchemaMigrator
{
    Task MigrateAsync();
}
