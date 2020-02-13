using System.Threading.Tasks;
using Abp.Application.Services;
using OpenShift.Sessions.Dto;

namespace OpenShift.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
