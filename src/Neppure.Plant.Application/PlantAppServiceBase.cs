using Abp.Application.Services;

namespace Neppure.Plant
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class PlantAppServiceBase : ApplicationService
    {
        protected PlantAppServiceBase()
        {
            LocalizationSourceName = PlantConsts.LocalizationSourceName;
        }
    }
}