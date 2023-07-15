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
        Dictionary<string, string[]> colorSchemeLanguage;


        public Settings()
        {
            InitializeComponent();

            mainMenu = Application.OpenForms.OfType<MainMenu>().FirstOrDefault();

            System.Configuration.SettingsProperty Language = new System.Configuration.SettingsProperty("Language");
            System.Configuration.SettingsProperty ColorTheme = new System.Configuration.SettingsProperty("ColorTheme");
            System.Configuration.SettingsProperty SeparatorSymbol = new System.Configuration.SettingsProperty("SeparatorSymbol");
            System.Configuration.SettingsProperty NumbersAfterSeparator = new System.Configuration.SettingsProperty("NumbersAfterSeparator");

            Properties.Settings.Default.Save();

            colorSchemeLanguage = CreateColorSchemes();

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
            SetColorThemeSetting(ColorThemeField.Text, colorSchemeLanguage);
            SetDefaultOriginalCurrencySetting(DefaultOriginalCurrencyField.Text);
            SetNumbersAfterSeparatorSetting(int.Parse(ChangeNumbersAfterSeparatorField.Text));

            Properties.Settings.Default.Save();

            mainMenu.ChangeLanguage(Convert.ToString(Properties.Settings.Default["Language"]));
            mainMenu.ChangeColorTheme(Convert.ToString(Properties.Settings.Default["ColorTheme"]));
            mainMenu.ChangeDefaultOriginalCurrency(Convert.ToString(Properties.Settings.Default["DefaultOriginalCurrency"]));

            this.Close();
        }

        private Dictionary<string, string[]> CreateColorSchemes()
        {
            Dictionary<string, string[]> schemes = new Dictionary<string, string[]>();
            schemes["LIGHT"] = new string[] { "Light", "Світла"};
            schemes["DARK"] = new string[] { "Dark", "Темна"};
            return schemes;
        }

        private void ChangeLanguage(string language)
        {
            if (language == "Українська")
            {
                LanguageField.Text = "Мова";
                ColorThemeField.Text = "Кольорова схема";
                NumbersAfterSeparatorLabel.Text = "С-лів п-я роздільника";

                ColorThemeField.Items[0] = "Світла";
                ColorThemeField.Items[1] = "Темна";

                this.Text = "Налаштування";
            }
            else if (language == "English")
            {
                LanguageField.Text = "Language";
                ColorThemeField.Text = "Color theme";
                NumbersAfterSeparatorLabel.Text = "Sym. after separator";

                ColorThemeField.Items[0] = "Light";
                ColorThemeField.Items[1] = "Dark";

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
            Properties.Settings.Default["Language"] = language;
        }

        private void SetColorThemeSetting(string searchValue, Dictionary<string, string[]> colorSchemeLanguage)
        {
            foreach (KeyValuePair<string, string[]> scheme in colorSchemeLanguage)
            {
                string schemeName = scheme.Key;
                string[] schemeNames = scheme.Value;

                foreach (string name in schemeNames)
                {
                    if (name == searchValue)
                    {
                        Properties.Settings.Default["ColorTheme"] = schemeName;
                    }
                }
            }
        }

        private void SetDefaultOriginalCurrencySetting(string defaultOriginalCurrency)
        {
            if (defaultOriginalCurrency == "") return;
            else Properties.Settings.Default["DefaultOriginalCurrency"] = defaultOriginalCurrency;
        }

        private void SetNumbersAfterSeparatorSetting(int numbersAfterSeparator)
        {
            Properties.Settings.Default["NumbersAfterSeparator"] = numbersAfterSeparator;
        }
    }
}
