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

namespace CurrencyCalculator
{
    public partial class Settings : Form
    {
        private MainMenu mainMenu;
        public Settings()
        {
            InitializeComponent();
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            string language = ChangeLanguageField.Text;
            string colorTheme = ChangeColorThemeField.Text;
            string seraratorSymbol = ChangeSeparatorSymbolField.Text;
            int numbersAfterSeparator = int.Parse(ChangeNumbersAfterSeparatorField.Text);

            mainMenu = Application.OpenForms.OfType<MainMenu>().FirstOrDefault(); // Получаем ссылку на экземпляр главной формы MainMenu

            mainMenu.ChangeColorTheme(colorTheme);
        }
    }
}
