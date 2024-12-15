using Acme.StudentsManagement.Localization;
using Volo.Abp.Application.Services;

namespace Acme.StudentsManagement;

/* Inherit your application services from this class.
 */
public abstract class StudentsManagementAppService : ApplicationService
{
    protected StudentsManagementAppService()
    {
        LocalizationResource = typeof(StudentsManagementResource);
    }

}
