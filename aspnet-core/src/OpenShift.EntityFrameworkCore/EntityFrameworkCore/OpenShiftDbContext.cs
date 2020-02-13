using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using OpenShift.Authorization.Roles;
using OpenShift.Authorization.Users;
using OpenShift.MultiTenancy;

namespace OpenShift.EntityFrameworkCore
{
    public class OpenShiftDbContext : AbpZeroDbContext<Tenant, Role, User, OpenShiftDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public OpenShiftDbContext(DbContextOptions<OpenShiftDbContext> options)
            : base(options)
        {
        }
    }
}
