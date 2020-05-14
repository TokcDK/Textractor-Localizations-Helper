using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Textractor_Localizations_Helper
{
    public partial class TextractorLocalizationsHelper : Form
    {
        public TextractorLocalizationsHelper()
        {
            InitializeComponent();
        }

        private void OpenTextcppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenTextCPP();
        }

        private void OpenTextCPP()
        {
            using (OpenFileDialog SelectedFile = new OpenFileDialog() { Filter = "text.cpp|text.cpp" })
            {
                if (SelectedFile.ShowDialog() == DialogResult.OK)
                {
                    if (SelectedFile.FileName != null && Path.GetFileName(SelectedFile.FileName).ToUpper() == "TEXT.CPP")
                    {
                        Properties.Settings.Default.FilePath = SelectedFile.FileName;
                        TLangComboBox.Items.Clear();
                        GetLanguages();
                        System.Media.SystemSounds.Asterisk.Play();
                    }
                }
            }
        }

        private void GetLanguages()
        {
            if (Properties.Settings.Default.FilePath.Length == 0)
            {
                return;
            }

            try
            {
                using (StreamReader sr = new StreamReader(Properties.Settings.Default.FilePath))
                {
                    string line;
                    bool getLanguages = false;
                    while (!sr.EndOfStream)
                    {
                        line = sr.ReadLine();

                        if (getLanguages)
                        {
                            if (line.StartsWith("#define"))
                            {
                                TLangComboBox.Items.Add(line.Split(' ')[1]);
                            }
                            else
                            {
                                return;
                            }
                        }
                        else
                        {
                            if (line == "#if 0")
                            {
                                getLanguages = true;
                            }
                        }
                    }
                }
            }
            catch
            {
            }
        }

        private void TLangComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TLangComboBox.SelectedItem != null && TLangComboBox.SelectedItem.ToString().Length > 0)
            {
                GetLanguageStringsAndFillData();
            }
        }

        DataTable DT;
        Dictionary<string, string> VarCodePairEN;
        private void GetLanguageStringsAndFillData()
        {
            var CurrentLanguage = TLangComboBox.SelectedItem.ToString();
            Dictionary<string, string> VarValuePairEN = new Dictionary<string, string>();
            Dictionary<string, string> VarValuePairTarget = new Dictionary<string, string>();
            VarCodePairEN = new Dictionary<string, string>();
            bool englishAdded = false;
            using (StreamReader sr = new StreamReader(Properties.Settings.Default.FilePath))
            {
                var regexExpression = @"^const (char|wchar_t)\* ([A-Z0-9_]+) \= ([u8LR]{0,3})""([\S\s]+)"";[\s]*$";
                string line = string.Empty;
                StringBuilder vValue = new StringBuilder();
                while (!line.StartsWith("static auto"))
                {
                    line = sr.ReadLine();
                    if (line.StartsWith("const "))
                    {
                        if (line.EndsWith("\";"))
                        {
                            var cv = Regex.Replace(line, regexExpression, "$1{{|}}$2{{|}}$3{{|}}$4").Split(new[] { "{{|}}" }, StringSplitOptions.None);
                            VarValuePairEN.Add(cv[1], cv[3]);
                            VarCodePairEN.Add(cv[1], cv[2]);
                        }
                        else
                        {
                            vValue.AppendLine(line);
                            while (!line.EndsWith("\";"))
                            {
                                line = sr.ReadLine();
                                vValue.AppendLine(line);
                            }

                            var cv = Regex.Replace(vValue.ToString(), regexExpression, "$1{{|}}$2{{|}}$3{{|}}$4").Split(new[] { "{{|}}" }, StringSplitOptions.None);
                            VarValuePairEN.Add(cv[1], cv[3]);
                            VarCodePairEN.Add(cv[1], cv[2]);
                            vValue.Clear();
                        }
                        englishAdded = true;
                    }
                }

                bool targetFound = false;
                if (englishAdded)
                {
                    while (!sr.EndOfStream)
                    {
                        line = sr.ReadLine();
                        if (line.StartsWith("#ifdef " + CurrentLanguage))
                        {
                            targetFound = true;
                            break;
                        }
                    }

                    if (targetFound)
                    {
                        regexExpression = @"^	([A-Z0-9_]+) \= [u8LR]{0,3}""([\S\s]+)"";[\s]*$";
                        while (!line.StartsWith("#endif"))
                        {
                            line = sr.ReadLine();
                            if (line.StartsWith("	"))
                            {
                                if (line.EndsWith("\";"))
                                {
                                    var cv = Regex.Replace(line, regexExpression, "$1{{|}}$2").Split(new[] { "{{|}}" }, StringSplitOptions.None);
                                    VarValuePairTarget.Add(cv[0], cv[1]);
                                }
                                else
                                {
                                    vValue.AppendLine(line);
                                    while (!line.EndsWith("\";"))
                                    {
                                        line = sr.ReadLine();
                                        vValue.AppendLine(line);
                                    }

                                    var cv = Regex.Replace(vValue.ToString(), regexExpression, "$1{{|}}$2").Split(new[] { "{{|}}" }, StringSplitOptions.None);
                                    VarValuePairTarget.Add(cv[0], cv[1]);
                                    vValue.Clear();
                                }
                            }
                        }
                    }
                }
            }

            if (englishAdded && VarValuePairEN.Count > 0)
            {
                DT = new DataTable();
                DT.Columns.Add("Variable");
                DT.Columns.Add("ENGLISH");
                DT.Columns["ENGLISH"].ReadOnly = true;
                DT.Columns.Add(CurrentLanguage);
                var TargetHasValues = VarValuePairTarget.Count > 0;
                foreach (var key in VarValuePairEN.Keys)
                {
                    if (TargetHasValues && VarValuePairTarget.ContainsKey(key) && VarValuePairTarget[key] != VarValuePairEN[key])
                    {
                        DT.Rows.Add(key, VarValuePairEN[key], VarValuePairTarget[key]);
                    }
                    else
                    {
                        DT.Rows.Add(key, VarValuePairEN[key], string.Empty);
                    }
                }

                dataGridView1.DataSource = DT;
            }
            VarValuePairEN.Clear();
            VarValuePairTarget.Clear();
            System.Media.SystemSounds.Asterisk.Play();
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveTranslation();
        }

        private void SaveTranslation()
        {
            try
            {
                StringBuilder writeData = new StringBuilder();
                using (StreamReader sr = new StreamReader(Properties.Settings.Default.FilePath))
                {
                    string line = string.Empty;
                    var CurrentLanguage = TLangComboBox.SelectedItem.ToString();
                    bool NotSaved = true;

                    while (!sr.EndOfStream)
                    {
                        line = sr.ReadLine();
                        if (NotSaved && line == "#ifdef " + CurrentLanguage)
                        {
                            writeData.AppendLine(line);
                            foreach (DataRow row in DT.Rows)
                            {
                                if (string.IsNullOrEmpty(row[2] as string) || Equals(row[1], row[2]))
                                {
                                    continue;
                                }

                                writeData.AppendLine("	" + row[0] + " = " + VarCodePairEN[row[0] as string] + "\"" + row[2] + "\";");
                            }

                            do
                            {
                                line = sr.ReadLine();
                            }
                            while (!line.StartsWith("#endif"));

                            NotSaved = false;
                        }

                        if (NotSaved && line == "	return 0;")
                        {
                            writeData.AppendLine("#ifdef " + CurrentLanguage);

                            foreach (DataRow row in DT.Rows)
                            {
                                if (string.IsNullOrEmpty(row[2] as string) || Equals(row[1], row[2]))
                                {
                                    continue;
                                }

                                writeData.AppendLine("	" + row[0] + " = " + VarCodePairEN[row[0] as string] + "\"" + (string.IsNullOrEmpty(row[2] as string) ? row[1] : row[2]) + "\";");
                            }

                            writeData.AppendLine("#endif // " + CurrentLanguage + Environment.NewLine);
                        }
                        writeData.AppendLine(line);
                    }
                }

                File.WriteAllText(Properties.Settings.Default.FilePath, writeData.ToString());
                writeData.Clear();
                System.Media.SystemSounds.Asterisk.Play();
            }
            catch
            {
                System.Media.SystemSounds.Exclamation.Play();
            }
        }

        private void NoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "The utility was made by Denis K<TokcDk> because I was too lazy" + Environment.NewLine + "to search/copy/paste/translate all new added strings" + Environment.NewLine +
                Environment.NewLine + Environment.NewLine +
                "How to translate:" + Environment.NewLine +
                "1. Open text.cpp (Ctrl+O)" + Environment.NewLine +
                "2. Select your target language" + Environment.NewLine +
                "3. Translate" + Environment.NewLine +
                "4. Save (Ctrl+S)" + Environment.NewLine +
                Environment.NewLine +
                Environment.NewLine +
                "Notes:" + Environment.NewLine +
                "New strings will be added from original English." + Environment.NewLine +
                "Empty lines and lines identical to original will be ignored while saving." + Environment.NewLine +
                Environment.NewLine
                );
        }

        private void TextractorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/Artikash/Textractor");
        }

        AddNewLanguage AddNewLanguageForm;
        internal bool addLangOpened = false;
        private void AddNewLanguageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (addLangOpened)
            {
                return;
            }

            if (TLangComboBox == null || TLangComboBox.Items.Count == 0)
            {
                OpenTextCPP();
                if (TLangComboBox == null || TLangComboBox.Items.Count == 0)
                {
                    return;
                }
            }

            if (AddNewLanguageForm == null)
            {
                AddNewLanguageForm = new AddNewLanguage(this);
            }
            addLangOpened = true;
            AddNewLanguageForm.Show();
        }
    }
}
