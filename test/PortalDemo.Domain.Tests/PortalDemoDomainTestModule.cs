using Volo.Abp.Modularity;

namespace PortalDemo;

[DependsOn(
    typeof(PortalDemoDomainModule),
    typeof(PortalDemoTestBaseModule)
)]
public class PortalDemoDomainTestModule : AbpModule
{

}
