using PortalDemo.Localization;
using Volo.Abp.AspNetCore.Components;

namespace PortalDemo.Blazor.Client;

public abstract class PortalDemoComponentBase : AbpComponentBase
{
    protected PortalDemoComponentBase()
    {
        LocalizationResource = typeof(PortalDemoResource);
    }
}
