using System;
using System.IO;
using System.Windows.Forms;

namespace Textractor_Localizations_Helper
{
    public partial class AddNewLanguage : Form
    {
        readonly TextractorLocalizationsHelper main;
        public AddNewLanguage(TextractorLocalizationsHelper main)
        {
            InitializeComponent();
            this.main = main;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (NewLanguageEnterTextBox.Text.Length == 0)
            {
                return;
            }

            var NewLanguageName = NewLanguageEnterTextBox.Text.ToUpper();

            var textCPPContent = File.ReadAllText(Properties.Settings.Default.FilePath);
            if (!main.TLangComboBox.Items.Contains(NewLanguageName))
            {
                string LastLanguageIdentifier = "#define " + main.TLangComboBox.Items[main.TLangComboBox.Items.Count - 1].ToString();
                File.WriteAllText(Properties.Settings.Default.FilePath, textCPPContent
                    .Replace(LastLanguageIdentifier
                    , LastLanguageIdentifier
                    + Environment.NewLine + "#define " + NewLanguageName)
                    );

                main.TLangComboBox.Items.Add(NewLanguageEnterTextBox.Text.ToUpper());
            }
            System.Media.SystemSounds.Asterisk.Play();
            main.addLangOpened = false;
            this.Close();
        }
    }
}
