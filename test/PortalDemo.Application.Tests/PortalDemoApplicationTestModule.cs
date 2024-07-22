using Volo.Abp.Modularity;

namespace PortalDemo;

[DependsOn(
    typeof(PortalDemoApplicationModule),
    typeof(PortalDemoDomainTestModule)
)]
public class PortalDemoApplicationTestModule : AbpModule
{

}
