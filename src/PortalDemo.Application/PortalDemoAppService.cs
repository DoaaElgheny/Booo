using System;
using System.Collections.Generic;
using System.Text;
using PortalDemo.Localization;
using Volo.Abp.Application.Services;

namespace PortalDemo;

/* Inherit your application services from this class.
 */
public abstract class PortalDemoAppService : ApplicationService
{
    protected PortalDemoAppService()
    {
        LocalizationResource = typeof(PortalDemoResource);
    }
}
