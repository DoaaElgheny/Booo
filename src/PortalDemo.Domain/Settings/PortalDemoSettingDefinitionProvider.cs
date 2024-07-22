using Volo.Abp.Settings;

namespace PortalDemo.Settings;

public class PortalDemoSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(PortalDemoSettings.MySetting1));
    }
}
