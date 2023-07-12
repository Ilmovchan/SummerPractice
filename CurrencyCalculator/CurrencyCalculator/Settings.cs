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

            Properties.Settings.Default.Save();
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            ChangeLanguage(Convert.ToString(Properties.Settings.Default["Language"]));
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default["Language"] = ChangeLanguageField.Text;
            Properties.Settings.Default["ColorTheme"] = ChangeColorThemeField.Text;
            string seraratorSymbol = ChangeSeparatorSymbolField.Text;
            int numbersAfterSeparator = int.Parse(ChangeNumbersAfterSeparatorField.Text);

            

            mainMenu.ChangeLanguage(Convert.ToString(Properties.Settings.Default["Language"]));
            mainMenu.ChangeColorTheme(Convert.ToString(Properties.Settings.Default["ColorTheme"]));
        }

        public void ChangeLanguage(string language)
        {
            if (language == "Українська" || language == "Ukraininan")
            {
                ChangeLanguageField.Text = "Мова";
                ChangeColorThemeField.Text = "Кольорова схема";
                ChangeSeparatorSymbolField.Text = "Символ роздільника";
                ChangeNumbersAfterSeparatorLabel.Text = "С-лів п-я роздільника";
            }
            else if (language == "Англійська" || language == "English")
            {
                ChangeLanguageField.Text = "Language";
                ChangeColorThemeField.Text = "Color theme";
                ChangeSeparatorSymbolField.Text = "Separator symbol";
                ChangeNumbersAfterSeparatorLabel.Text = "Sym. after separator";
            }
        }
    }
}
