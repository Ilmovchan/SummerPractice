using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Windows.Forms.VisualStyles;
using System.Globalization;

namespace CurrencyCalculator
{
    public partial class Settings : Form
    {
        private MainMenu mainMenu;
        public Settings()
        {
            InitializeComponent();

            mainMenu = Application.OpenForms.OfType<MainMenu>().FirstOrDefault();

            System.Configuration.SettingsProperty Language = new System.Configuration.SettingsProperty("Language");
            System.Configuration.SettingsProperty ColorTheme = new System.Configuration.SettingsProperty("ColorTheme");
            System.Configuration.SettingsProperty SeparatorSymbol = new System.Configuration.SettingsProperty("SeparatorSymbol");
            System.Configuration.SettingsProperty NumbersAfterSeparator = new System.Configuration.SettingsProperty("NumbersAfterSeparator");

            Properties.Settings.Default.Save();

            this.Load += Settings_Load;
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            ChangeLanguage(Convert.ToString(Properties.Settings.Default["Language"]));
            ChangeColorTheme(Convert.ToString(Properties.Settings.Default["ColorTheme"]));
            ChangeNumbersAfterSeparatorField.Text = Convert.ToString(Properties.Settings.Default["NumbersAfterSeparator"]);
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            SetLanguageSetting(LanguageField.Text);
            SetColorThemeSetting(ColorThemeField.Text);
            SetDefaultOriginalCurrencySetting(DefaultOriginalCurrencyField.Text);
            SetNumbersAfterSeparatorSetting(int.Parse(ChangeNumbersAfterSeparatorField.Text));

            mainMenu.ChangeLanguage(Convert.ToString(Properties.Settings.Default["Language"]));
            mainMenu.ChangeColorTheme(Convert.ToString(Properties.Settings.Default["ColorTheme"]));
            mainMenu.ChangeDefaultOriginalCurrency(Convert.ToString(Properties.Settings.Default["DefaultOriginalCurrency"]));

            Properties.Settings.Default.Save();
            this.Close();
        }

        private void ChangeLanguage(string language)
        {
            if (language == "UA")
            {
                LanguageField.Text = "Мова";
                ColorThemeField.Text = "Кольорова схема";
                DefaultOriginalCurrencyField.Text = "Валюта за замовчуванням";
                NumbersAfterSeparatorLabel.Text = "С-лів п-я роздільника";

                LanguageField.Items[0] = "Українська";
                LanguageField.Items[1] = "Англійська";

                ColorThemeField.Items[0] = "Світла";
                ColorThemeField.Items[1] = "Темна";

                DefaultOriginalCurrencyField.Items[0] = "Валюта за замовчуванням";

                this.Text = "Налаштування";
            }
            else if (language == "ENG")
            {
                LanguageField.Text = "Language";
                ColorThemeField.Text = "Color theme";
                DefaultOriginalCurrencyField.Text = "Default currency";
                NumbersAfterSeparatorLabel.Text = "Sym. after separator";

                LanguageField.Items[0] = "Ukrainian";
                LanguageField.Items[1] = "English";

                ColorThemeField.Items[0] = "Light";
                ColorThemeField.Items[1] = "Dark";

                DefaultOriginalCurrencyField.Items[0] = "Default currency";


                this.Text = "Settings";
            }
        }

        private void ChangeColorTheme(string colorTheme)
        {
            if (colorTheme == "LIGHT")
            {
                this.BackColor = System.Drawing.Color.WhiteSmoke;

                LanguageField.BackColor = System.Drawing.SystemColors.Window;
                ColorThemeField.BackColor = System.Drawing.SystemColors.Window;
                DefaultOriginalCurrencyField.BackColor = System.Drawing.SystemColors.Window;

                NumbersAfterSeparatorLabel.BackColor = System.Drawing.SystemColors.Window;
                ChangeNumbersAfterSeparatorField.BackColor = System.Drawing.SystemColors.Window;

                LanguageField.ForeColor = System.Drawing.Color.Black;
                ColorThemeField.ForeColor = System.Drawing.Color.Black;
                DefaultOriginalCurrencyField.ForeColor = System.Drawing.Color.Black;

                NumbersAfterSeparatorLabel.ForeColor = System.Drawing.Color.Black;
                ChangeNumbersAfterSeparatorField.ForeColor = System.Drawing.Color.Black;

                AcceptButton.Image = Image.FromFile("../../../icons/icon_accept_circle_black.png");
                ReturnButton.Image = Image.FromFile("../../../icons/back_icon_black.png");
            }
            if (colorTheme == "DARK")
            {
                this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(47)))));

                LanguageField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(47)))));
                ColorThemeField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(47)))));
                DefaultOriginalCurrencyField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(47)))));

                NumbersAfterSeparatorLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(47)))));
                ChangeNumbersAfterSeparatorField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(47)))));

                LanguageField.ForeColor = System.Drawing.Color.White;
                ColorThemeField.ForeColor = System.Drawing.Color.White;
                DefaultOriginalCurrencyField.ForeColor = System.Drawing.Color.White;

                NumbersAfterSeparatorLabel.ForeColor = System.Drawing.Color.White;
                ChangeNumbersAfterSeparatorField.ForeColor = System.Drawing.Color.White;

                AcceptButton.Image = Image.FromFile("../../../icons/icon_accept_circle_white.png");
                ReturnButton.Image = Image.FromFile("../../../icons/back_icon_white.png");
            }
        }

        private void SetLanguageSetting(string language)
        {
            if (language == "Ukrainian" || language == "Українська")
            {
                Properties.Settings.Default["Language"] = "UA";
            }
            else if (language == "English" || language == "Англійська")
            {
                Properties.Settings.Default["Language"] = "ENG";
            }
            else return;
        }

        private void SetColorThemeSetting(string colorTheme)
        {
            if (colorTheme == "Light" || colorTheme == "Світла")
            {
                Properties.Settings.Default["ColorTheme"] = "LIGHT";
            }
            else if (colorTheme == "Dark" || colorTheme == "Темна")
            {
                Properties.Settings.Default["ColorTheme"] = "DARK";
            }
            else return;
        }

        private void SetDefaultOriginalCurrencySetting(string defaultOriginalCurrency)
        {
            if (defaultOriginalCurrency == "Default currency" || defaultOriginalCurrency == "Валюта за замовчуванням")
            {
                Properties.Settings.Default["DefaultOriginalCurrency"] = "DEFAULT";
            }
            else Properties.Settings.Default["DefaultOriginalCurrency"] = defaultOriginalCurrency;

        }

        private void SetNumbersAfterSeparatorSetting(int numbersAfterSeparator)
        {
            Properties.Settings.Default["NumbersAfterSeparator"] = numbersAfterSeparator;
        }
    }
}
