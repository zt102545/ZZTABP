using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace ZZT.ABP.EntityFrameworkCore
{
    [DependsOn(
        typeof(ABPEntityFrameworkCoreModule)
        )]
    public class ABPEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<ABPMigrationsDbContext>();
        }
    }
}
