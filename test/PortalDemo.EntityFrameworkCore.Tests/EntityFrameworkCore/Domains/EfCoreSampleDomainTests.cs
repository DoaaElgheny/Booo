using PortalDemo.Samples;
using Xunit;

namespace PortalDemo.EntityFrameworkCore.Domains;

[Collection(PortalDemoTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<PortalDemoEntityFrameworkCoreTestModule>
{

}
