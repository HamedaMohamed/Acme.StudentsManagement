using Acme.StudentsManagement.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Acme.StudentsManagement.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class StudentsManagementController : AbpControllerBase
{
    protected StudentsManagementController()
    {
        LocalizationResource = typeof(StudentsManagementResource);
    }
}
