﻿using System.Threading.Tasks;
using Abp.Localization;
using Microsoft.AspNetCore.Mvc;

namespace Neppure.Plant.Web.Views.Shared.Components.LanguageSelection
{
    public class LanguageSelectionViewComponent : ViewComponent
    {
        private readonly ILanguageManager _languageManager;

        public LanguageSelectionViewComponent(ILanguageManager languageManager)
        {
            _languageManager = languageManager;
        }

        public IViewComponentResult Invoke()
        {
            var model = new LanguageSelectionViewModel
            {
                CurrentLanguage = _languageManager.CurrentLanguage,
                Languages = _languageManager.GetLanguages(),
                CurrentUrl = Request.Path
            };

            return View(model);
        }
    }
}
