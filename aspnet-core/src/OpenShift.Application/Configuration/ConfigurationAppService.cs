using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using OpenShift.Configuration.Dto;

namespace OpenShift.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : OpenShiftAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
