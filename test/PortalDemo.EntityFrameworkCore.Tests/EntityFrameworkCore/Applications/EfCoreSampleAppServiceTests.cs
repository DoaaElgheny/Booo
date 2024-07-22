using PortalDemo.Samples;
using Xunit;

namespace PortalDemo.EntityFrameworkCore.Applications;

[Collection(PortalDemoTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<PortalDemoEntityFrameworkCoreTestModule>
{

}
