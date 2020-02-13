using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace OpenShift.EntityFrameworkCore
{
    public static class OpenShiftDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<OpenShiftDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<OpenShiftDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
