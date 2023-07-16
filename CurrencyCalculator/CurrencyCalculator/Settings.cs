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
using System.Runtime.CompilerServices;
using CurrencyCalculator.Config.UI.Settings;

namespace CurrencyCalculator
{
    public partial class Settings : Form
    {
        private MainMenu mainMenu;
        Dictionary<string, string[]> colorSchemeLanguage;
        string[] languageList = { "English", "Ukrainian" };



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
            ChangeLanguage(Convert.ToString(Properties.Settings.Default.Language));
            ChangeColorTheme(Convert.ToString(Properties.Settings.Default.ColorTheme));
            NumbersAfterSeparatorField.Text = Convert.ToString(Properties.Settings.Default.NumbersAfterSeparator);
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
            SetNumbersAfterSeparatorSetting(int.Parse(NumbersAfterSeparatorField.Text));

            Properties.Settings.Default.Save();

            mainMenu.ChangeLanguage(Convert.ToString(Properties.Settings.Default.Language));
            mainMenu.ChangeColorTheme(Convert.ToString(Properties.Settings.Default.ColorTheme));
            mainMenu.ChangeDefaultOriginalCurrency(Convert.ToString(Properties.Settings.Default.OriginalCurrency));

            this.Close();
        }

        private Dictionary<string, string[]> CreateColorSchemes()
        {
            Dictionary<string, string[]> schemes = new Dictionary<string, string[]>();
            schemes["Light"] = new string[] { "Light", "Світла"};
            schemes["Dark"] = new string[] { "Dark", "Темна"};
            return schemes;
        }

        private void ChangeLanguage(string language)
        {
            Language languageData = new Language();

            string selectedLanguage = language;
            LanguageText languageText = typeof(Language).GetProperty(selectedLanguage)?.GetValue(languageData) as LanguageText;

            this.Text = languageText?.Title;
            LanguageField.Text = languageText?.Language;
            ColorThemeField.Text = languageText?.ColorTheme;
            NumbersAfterSeparatorLabel.Text = languageText?.NumbersAfterSeparator;
            ColorThemeField.Items[0] = languageText?.ColorThemeItem0;
            ColorThemeField.Items[1] = languageText?.ColorThemeItem1;
        }

        private void ChangeColorTheme(string colorTheme)
        {

            ColorTheme colorThemeData = new ColorTheme();
            string selectedColorTheme = colorTheme;
            ColorThemeElements selectedColorThemeElements = typeof(ColorTheme).GetProperty(selectedColorTheme)?.GetValue(colorThemeData) as ColorThemeElements;

            if (selectedColorTheme != null)
            {
                this.BackColor = (Color)selectedColorThemeElements?.Background;

                LanguageField.BackColor = (Color)selectedColorThemeElements?.LanguageBg;
                ColorThemeField.BackColor = (Color)selectedColorThemeElements?.ColorThemeBg;
                DefaultOriginalCurrencyField.BackColor = (Color)selectedColorThemeElements?.DefaultOriginalCurrencyBg;

                NumbersAfterSeparatorLabel.BackColor = (Color)selectedColorThemeElements?.NumbersAfterSeparatorLabelBg;
                NumbersAfterSeparatorField.BackColor = (Color)selectedColorThemeElements?.NumbersAfterSeparatorFieldBg;

                LanguageField.ForeColor = (Color)selectedColorThemeElements?.LanguageText;
                ColorThemeField.ForeColor = (Color)selectedColorThemeElements?.ColorThemeText;
                DefaultOriginalCurrencyField.ForeColor =(Color)selectedColorThemeElements?.DefaultOriginalCurrencyText;

                NumbersAfterSeparatorLabel.ForeColor = (Color)selectedColorThemeElements?.NumbersAfterSeparatorLabelText;
                NumbersAfterSeparatorField.ForeColor = (Color)selectedColorThemeElements?.NumbersAfterSeparatorFieldText;

                AcceptButton.Image = Image.FromFile("../../../icons/icon_accept_circle_black.png");
                ReturnButton.Image = Image.FromFile("../../../icons/back_icon_black.png");
            }

/*            if (colorTheme == "LIGHT")
            {
                this.BackColor = System.Drawing.Color.WhiteSmoke;

                LanguageField.BackColor = System.Drawing.SystemColors.Window;
                ColorThemeField.BackColor = System.Drawing.SystemColors.Window;
                DefaultOriginalCurrencyField.BackColor = System.Drawing.SystemColors.Window;

                NumbersAfterSeparatorLabel.BackColor = System.Drawing.SystemColors.Window;
                NumbersAfterSeparatorField.BackColor = System.Drawing.SystemColors.Window;

                LanguageField.ForeColor = System.Drawing.Color.Black;
                ColorThemeField.ForeColor = System.Drawing.Color.Black;
                DefaultOriginalCurrencyField.ForeColor = System.Drawing.Color.Black;

                NumbersAfterSeparatorLabel.ForeColor = System.Drawing.Color.Black;
                NumbersAfterSeparatorField.ForeColor = System.Drawing.Color.Black;

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
                NumbersAfterSeparatorField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(47)))));

                LanguageField.ForeColor = System.Drawing.Color.White;
                ColorThemeField.ForeColor = System.Drawing.Color.White;
                DefaultOriginalCurrencyField.ForeColor = System.Drawing.Color.White;

                NumbersAfterSeparatorLabel.ForeColor = System.Drawing.Color.White;
                NumbersAfterSeparatorField.ForeColor = System.Drawing.Color.White;

                AcceptButton.Image = Image.FromFile("../../../icons/icon_accept_circle_white.png");
                ReturnButton.Image = Image.FromFile("../../../icons/back_icon_white.png");
            }*/
        }

        private void SetLanguageSetting(string language)
        {
            foreach (string element in languageList)
            {
                if (element == language) Properties.Settings.Default.Language = language;
            }
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
                        Properties.Settings.Default.ColorTheme = schemeName;
                    }
                }
            }
        }

        private void SetDefaultOriginalCurrencySetting(string defaultOriginalCurrency)
        {
            if (defaultOriginalCurrency == "") return;
            else Properties.Settings.Default.OriginalCurrency = defaultOriginalCurrency;
        }

        private void SetNumbersAfterSeparatorSetting(int numbersAfterSeparator)
        {
            Properties.Settings.Default.NumbersAfterSeparator = numbersAfterSeparator;
        }
    }
}
