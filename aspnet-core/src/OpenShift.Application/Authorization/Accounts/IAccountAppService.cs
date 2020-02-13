using System.Threading.Tasks;
using Abp.Application.Services;
using OpenShift.Authorization.Accounts.Dto;

namespace OpenShift.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
