using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace CurrencyCalculator.Config.UI.MainMenu
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

                CashAmountBg = System.Drawing.SystemColors.ScrollBar,
                OriginalCurrencyBg = System.Drawing.SystemColors.ScrollBar,
                SecondCurrencyBg = System.Drawing.SystemColors.ScrollBar,
                ResultBg = System.Drawing.SystemColors.ScrollBar,
                ExchangeBg = System.Drawing.SystemColors.ScrollBar,

                CashAmountText = System.Drawing.Color.Black,
                OriginalCurrencyText = System.Drawing.Color.Black,
                SecondCurrencyText = System.Drawing.Color.Black,
                ResultText = System.Drawing.Color.Black,
                ExchangeText = System.Drawing.Color.Black,

                CashAmountLabelText = System.Drawing.Color.Black,
                OriginalCurrencyLabelText = System.Drawing.Color.Black,
                SecondCurrencyLabelText = System.Drawing.Color.Black,
                ResultLabelText = System.Drawing.Color.Black,
                ExchangeLabelText = System.Drawing.Color.Black,

                ConvertBg = System.Drawing.Color.PowderBlue,
                ConvertText = System.Drawing.Color.Black,
                ConvertBorder = System.Drawing.Color.PowderBlue,

                CashAmountBorderStyle = BorderStyle.None,
            };

            Dark = new ColorThemeElements
            {
                Background = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(47))))),

                CashAmountBg = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(47))))),
                OriginalCurrencyBg = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(47))))),
                SecondCurrencyBg = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(47))))),
                ResultBg = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(47))))),
                ExchangeBg = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(47))))),

                CashAmountText = System.Drawing.Color.White,
                OriginalCurrencyText = System.Drawing.Color.White,
                SecondCurrencyText = System.Drawing.Color.White,
                ResultText = System.Drawing.Color.White,
                ExchangeText = System.Drawing.Color.White,

                CashAmountLabelText = System.Drawing.Color.White,
                OriginalCurrencyLabelText = System.Drawing.Color.White,
                SecondCurrencyLabelText = System.Drawing.Color.White,
                ResultLabelText = System.Drawing.Color.White,
                ExchangeLabelText = System.Drawing.Color.White,

                ConvertBg = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(74)))), ((int)(((byte)(232))))),
                ConvertText = System.Drawing.Color.White,
                ConvertBorder = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(74)))), ((int)(((byte)(232))))),

                CashAmountBorderStyle = BorderStyle.FixedSingle,
            };
        }
    }
    public class ColorThemeElements
    {
        public Color Background { get; set; }

        public Color CashAmountBg { get; set; }
        public Color OriginalCurrencyBg { get; set; }
        public Color SecondCurrencyBg { get; set; }
        public Color ResultBg { get; set; }
        public Color ExchangeBg { get; set; }

        public Color CashAmountText { get; set; }
        public Color OriginalCurrencyText { get; set; }
        public Color SecondCurrencyText { get; set; }
        public Color ResultText { get; set; }
        public Color ExchangeText { get; set; }

        public Color CashAmountLabelText { get; set; }
        public Color OriginalCurrencyLabelText { get; set; }
        public Color SecondCurrencyLabelText { get; set; }
        public Color ResultLabelText { get; set; }
        public Color ExchangeLabelText { get; set; }

        public Color ConvertBg { get; set; }
        public Color ConvertText { get; set; }
        public Color ConvertBorder { get; set; }

        public BorderStyle CashAmountBorderStyle { get; set; }
    }
}
