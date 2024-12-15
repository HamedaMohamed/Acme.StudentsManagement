using Acme.StudentsManagement.Samples;
using Xunit;

namespace Acme.StudentsManagement.EntityFrameworkCore.Applications;

[Collection(StudentsManagementTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<StudentsManagementEntityFrameworkCoreTestModule>
{

}
