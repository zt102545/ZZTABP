using ZZT.ABP.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace ZZT.ABP.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(ABPEntityFrameworkCoreDbMigrationsModule),
        typeof(ABPApplicationContractsModule)
        )]
    public class ABPDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
