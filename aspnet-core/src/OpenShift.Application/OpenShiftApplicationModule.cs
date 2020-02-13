using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using OpenShift.Authorization;

namespace OpenShift
{
    [DependsOn(
        typeof(OpenShiftCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class OpenShiftApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<OpenShiftAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(OpenShiftApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
