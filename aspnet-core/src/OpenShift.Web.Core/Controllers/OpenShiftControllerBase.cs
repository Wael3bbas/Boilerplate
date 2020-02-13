using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace OpenShift.Controllers
{
    public abstract class OpenShiftControllerBase: AbpController
    {
        protected OpenShiftControllerBase()
        {
            LocalizationSourceName = OpenShiftConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
