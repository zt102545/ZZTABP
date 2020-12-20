using ZZT.ABP.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace ZZT.ABP
{
    [DependsOn(
        typeof(ABPEntityFrameworkCoreTestModule)
        )]
    public class ABPDomainTestModule : AbpModule
    {

    }
}