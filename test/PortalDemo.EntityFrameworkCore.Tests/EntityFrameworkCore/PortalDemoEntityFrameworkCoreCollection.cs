using Xunit;

namespace PortalDemo.EntityFrameworkCore;

[CollectionDefinition(PortalDemoTestConsts.CollectionDefinitionName)]
public class PortalDemoEntityFrameworkCoreCollection : ICollectionFixture<PortalDemoEntityFrameworkCoreFixture>
{

}
