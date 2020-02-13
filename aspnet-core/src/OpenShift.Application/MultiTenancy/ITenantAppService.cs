using Abp.Application.Services;
using Abp.Application.Services.Dto;
using OpenShift.MultiTenancy.Dto;

namespace OpenShift.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

