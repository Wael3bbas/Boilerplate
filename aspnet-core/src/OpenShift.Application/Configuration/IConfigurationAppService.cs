using System.Threading.Tasks;
using OpenShift.Configuration.Dto;

namespace OpenShift.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
