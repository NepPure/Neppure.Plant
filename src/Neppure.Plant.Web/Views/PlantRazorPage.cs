using Abp.AspNetCore.Mvc.Views;

namespace Neppure.Plant.Web.Views
{
    public abstract class PlantRazorPage<TModel> : AbpRazorPage<TModel>
    {
        protected PlantRazorPage()
        {
            LocalizationSourceName = PlantConsts.LocalizationSourceName;
        }
    }
}
