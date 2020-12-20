using Volo.Abp.Modularity;

namespace ZZT.ABP
{
    [DependsOn(
        typeof(ABPApplicationModule),
        typeof(ABPDomainTestModule)
        )]
    public class ABPApplicationTestModule : AbpModule
    {

    }
}