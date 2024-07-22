using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace PortalDemo.Data;

/* This is used if database provider does't define
 * IPortalDemoDbSchemaMigrator implementation.
 */
public class NullPortalDemoDbSchemaMigrator : IPortalDemoDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
