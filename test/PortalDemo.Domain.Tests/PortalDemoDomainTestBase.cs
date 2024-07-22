using Volo.Abp.Modularity;

namespace PortalDemo;

/* Inherit from this class for your domain layer tests. */
public abstract class PortalDemoDomainTestBase<TStartupModule> : PortalDemoTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
