using Volo.Abp.Modularity;

namespace PortalDemo;

public abstract class PortalDemoApplicationTestBase<TStartupModule> : PortalDemoTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
