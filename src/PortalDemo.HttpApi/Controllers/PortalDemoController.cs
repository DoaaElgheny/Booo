using PortalDemo.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace PortalDemo.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class PortalDemoController : AbpControllerBase
{
    protected PortalDemoController()
    {
        LocalizationResource = typeof(PortalDemoResource);
    }
}
