using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using OpenShift.Configuration;

namespace OpenShift.Web.Host.Startup
{
    [DependsOn(
       typeof(OpenShiftWebCoreModule))]
    public class OpenShiftWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public OpenShiftWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(OpenShiftWebHostModule).GetAssembly());
        }
    }
}
