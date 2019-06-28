using Abp.AspNetCore.Mvc.Controllers;

namespace Neppure.Plant.Web.Controllers
{
    public abstract class PlantControllerBase: AbpController
    {
        protected PlantControllerBase()
        {
            LocalizationSourceName = PlantConsts.LocalizationSourceName;
        }
    }
}