using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyCalculator.Config.UI.Settings
{
    public class Language
    {
        public LanguageText English { get; set; }
        public LanguageText Ukrainian { get; set; }

        public Language()
        {
            English = new LanguageText
            {
                Title = "Settings",
                Language = "Language",
                ColorTheme = "Color theme",
                NumbersAfterSeparator = "Sym. after separator",
                ColorThemeItem0 = "Light",
                ColorThemeItem1 = "Dark",
            };

            Ukrainian = new LanguageText
            {
                Title = "Налаштування",
                Language = "Мова",
                ColorTheme = "Кольорова схема",
                NumbersAfterSeparator = "С-лів п-я роздільника",
                ColorThemeItem0 = "Світла",
                ColorThemeItem1 = "Темна",
            };
        }
    }
    public class LanguageText
    {
        public string Title { get; set; }
        public string Language { get; set; }
        public string ColorTheme { get; set; }
        public string NumbersAfterSeparator { get; set; }
        public string ColorThemeItem0 { get; set; }
        public string ColorThemeItem1 { get; set; }

    }
}
