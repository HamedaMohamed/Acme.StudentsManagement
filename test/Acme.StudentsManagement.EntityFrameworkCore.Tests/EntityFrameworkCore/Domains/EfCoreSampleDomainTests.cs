using Acme.StudentsManagement.Samples;
using Xunit;

namespace Acme.StudentsManagement.EntityFrameworkCore.Domains;

[Collection(StudentsManagementTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<StudentsManagementEntityFrameworkCoreTestModule>
{

}
