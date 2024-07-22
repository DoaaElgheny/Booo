using Volo.Abp.DependencyInjection;
using Volo.Abp.MultiTenancy;
using Volo.Abp.Ui.Branding;

namespace PortalDemo;

[Dependency(ReplaceServices = true)]
public class PortalDemoBrandingProvider : DefaultBrandingProvider
{
    private readonly ICurrentTenant _currentTenant;
    public override string AppName => _currentTenant.Name ?? "PortalDemo";

    public PortalDemoBrandingProvider(ICurrentTenant currentTenant)
    {
        _currentTenant = currentTenant;
    }
}

