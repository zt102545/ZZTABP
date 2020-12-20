using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace ZZT.ABP
{
    [Dependency(ReplaceServices = true)]
    public class ABPBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "ABP";
    }
}
