using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace CurrencyCalculator.Config.UI.Settings
{
    public class ColorTheme
    {
        public ColorThemeElements Light { get; set; }
        public ColorThemeElements Dark { get; set; }

        public ColorTheme()
        {
            Light = new ColorThemeElements
            {
                Background = System.Drawing.Color.WhiteSmoke,

                LanguageBg = System.Drawing.SystemColors.Window,
                ColorThemeBg = System.Drawing.SystemColors.Window,
                DefaultOriginalCurrencyBg = System.Drawing.SystemColors.Window,
                NumbersAfterSeparatorFieldBg = System.Drawing.SystemColors.Window,
                NumbersAfterSeparatorLabelBg = System.Drawing.SystemColors.Window,

                LanguageText = System.Drawing.Color.Black,
                ColorThemeText = System.Drawing.Color.Black,
                DefaultOriginalCurrencyText = System.Drawing.Color.Black,
                NumbersAfterSeparatorFieldText = System.Drawing.Color.Black,
                NumbersAfterSeparatorLabelText = System.Drawing.Color.Black,
            };

            Light = new ColorThemeElements
            {
                Background = System.Drawing.Color.WhiteSmoke,

                LanguageBg = System.Drawing.SystemColors.Window,
                ColorThemeBg = System.Drawing.SystemColors.Window,
                DefaultOriginalCurrencyBg = System.Drawing.SystemColors.Window,
                NumbersAfterSeparatorFieldBg = System.Drawing.SystemColors.Window,
                NumbersAfterSeparatorLabelBg = System.Drawing.SystemColors.Window,

                LanguageText = System.Drawing.Color.Black,
                ColorThemeText = System.Drawing.Color.Black,
                DefaultOriginalCurrencyText = System.Drawing.Color.Black,
                NumbersAfterSeparatorFieldText = System.Drawing.Color.Black,
                NumbersAfterSeparatorLabelText = System.Drawing.Color.Black,
            };

            Dark = new ColorThemeElements
            {
                Background = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(47))))),

                LanguageBg = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(47))))),
                ColorThemeBg = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(47))))),
                DefaultOriginalCurrencyBg = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(47))))),
                NumbersAfterSeparatorFieldBg = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(47))))),
                NumbersAfterSeparatorLabelBg = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(47))))),

                LanguageText = System.Drawing.Color.White,
                ColorThemeText = System.Drawing.Color.White,
                DefaultOriginalCurrencyText = System.Drawing.Color.White,
                NumbersAfterSeparatorFieldText = System.Drawing.Color.White,
                NumbersAfterSeparatorLabelText = System.Drawing.Color.White,

            };
        }
    }
    public class ColorThemeElements
    {
        public Color Background { get; set; }

        public Color LanguageBg { get; set; }
        public Color ColorThemeBg { get; set; }
        public Color DefaultOriginalCurrencyBg { get; set; }
        public Color NumbersAfterSeparatorFieldBg { get; set; }
        public Color NumbersAfterSeparatorLabelBg { get; set; }

        public Color LanguageText { get; set; }
        public Color ColorThemeText { get; set; }
        public Color DefaultOriginalCurrencyText { get; set; }
        public Color NumbersAfterSeparatorFieldText { get; set; }
        public Color NumbersAfterSeparatorLabelText { get; set; }
    }
}
