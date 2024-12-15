using Xunit;

namespace Acme.StudentsManagement.EntityFrameworkCore;

[CollectionDefinition(StudentsManagementTestConsts.CollectionDefinitionName)]
public class StudentsManagementEntityFrameworkCoreCollection : ICollectionFixture<StudentsManagementEntityFrameworkCoreFixture>
{

}
