using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace PortalDemo.Blazor.WebApp.Tiered.Client;

[Dependency(ReplaceServices = true)]
public class PortalDemoBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "PortalDemo";
}
