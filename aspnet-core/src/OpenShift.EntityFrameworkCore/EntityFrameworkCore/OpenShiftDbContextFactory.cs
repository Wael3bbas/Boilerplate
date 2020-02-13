using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using OpenShift.Configuration;
using OpenShift.Web;

namespace OpenShift.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class OpenShiftDbContextFactory : IDesignTimeDbContextFactory<OpenShiftDbContext>
    {
        public OpenShiftDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<OpenShiftDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            OpenShiftDbContextConfigurer.Configure(builder, configuration.GetConnectionString(OpenShiftConsts.ConnectionStringName));

            return new OpenShiftDbContext(builder.Options);
        }
    }
}
