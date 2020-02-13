using Abp.Authorization;
using OpenShift.Authorization.Roles;
using OpenShift.Authorization.Users;

namespace OpenShift.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
