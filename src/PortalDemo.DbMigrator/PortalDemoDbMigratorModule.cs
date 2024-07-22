using PortalDemo.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace PortalDemo.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(PortalDemoEntityFrameworkCoreModule),
    typeof(PortalDemoApplicationContractsModule)
    )]
public class PortalDemoDbMigratorModule : AbpModule
{
}
