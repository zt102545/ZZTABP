using ZZT.ABP.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace ZZT.ABP.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class ABPController : AbpController
    {
        protected ABPController()
        {
            LocalizationResource = typeof(ABPResource);
        }
    }
}