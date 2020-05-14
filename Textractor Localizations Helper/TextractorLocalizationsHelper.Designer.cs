namespace Textractor_Localizations_Helper
{
    partial class TextractorLocalizationsHelper
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openTextcppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewLanguageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReadmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LinksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textractorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TLangComboBox = new System.Windows.Forms.ComboBox();
            this.TLangLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.OpenButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.AddNewLanguageButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.ReadmeToolStripMenuItem,
            this.LinksToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(623, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openTextcppToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openTextcppToolStripMenuItem
            // 
            this.openTextcppToolStripMenuItem.Name = "openTextcppToolStripMenuItem";
            this.openTextcppToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openTextcppToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.openTextcppToolStripMenuItem.Text = "Open Text.cpp";
            this.openTextcppToolStripMenuItem.Click += new System.EventHandler(this.OpenTextcppToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewLanguageToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // addNewLanguageToolStripMenuItem
            // 
            this.addNewLanguageToolStripMenuItem.Name = "addNewLanguageToolStripMenuItem";
            this.addNewLanguageToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addNewLanguageToolStripMenuItem.Text = "Add new language";
            this.addNewLanguageToolStripMenuItem.Click += new System.EventHandler(this.AddNewLanguageToolStripMenuItem_Click);
            // 
            // ReadmeToolStripMenuItem
            // 
            this.ReadmeToolStripMenuItem.Name = "ReadmeToolStripMenuItem";
            this.ReadmeToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.ReadmeToolStripMenuItem.Text = "ReadMe";
            this.ReadmeToolStripMenuItem.Click += new System.EventHandler(this.NoteToolStripMenuItem_Click);
            // 
            // LinksToolStripMenuItem
            // 
            this.LinksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.textractorToolStripMenuItem});
            this.LinksToolStripMenuItem.Name = "LinksToolStripMenuItem";
            this.LinksToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.LinksToolStripMenuItem.Text = "Links";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // textractorToolStripMenuItem
            // 
            this.textractorToolStripMenuItem.Name = "textractorToolStripMenuItem";
            this.textractorToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.textractorToolStripMenuItem.Text = "Textractor";
            this.textractorToolStripMenuItem.Click += new System.EventHandler(this.TextractorToolStripMenuItem_Click);
            // 
            // TLangComboBox
            // 
            this.TLangComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TLangComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TLangComboBox.FormattingEnabled = true;
            this.TLangComboBox.Location = new System.Drawing.Point(413, 3);
            this.TLangComboBox.Name = "TLangComboBox";
            this.TLangComboBox.Size = new System.Drawing.Size(120, 21);
            this.TLangComboBox.TabIndex = 1;
            this.TLangComboBox.SelectedIndexChanged += new System.EventHandler(this.TLangComboBox_SelectedIndexChanged);
            // 
            // TLangLabel
            // 
            this.TLangLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TLangLabel.AutoSize = true;
            this.TLangLabel.Location = new System.Drawing.Point(317, 6);
            this.TLangLabel.Name = "TLangLabel";
            this.TLangLabel.Size = new System.Drawing.Size(90, 13);
            this.TLangLabel.TabIndex = 2;
            this.TLangLabel.Text = "Target language:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(623, 354);
            this.panel1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(623, 354);
            this.dataGridView1.TabIndex = 0;
            // 
            // OpenButton
            // 
            this.OpenButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenButton.Location = new System.Drawing.Point(539, 2);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(20, 21);
            this.OpenButton.TabIndex = 4;
            this.OpenButton.Text = "O";
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenTextcppToolStripMenuItem_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.Location = new System.Drawing.Point(565, 2);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(20, 21);
            this.SaveButton.TabIndex = 5;
            this.SaveButton.Text = "S";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // AddNewLanguageButton
            // 
            this.AddNewLanguageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddNewLanguageButton.Location = new System.Drawing.Point(591, 2);
            this.AddNewLanguageButton.Name = "AddNewLanguageButton";
            this.AddNewLanguageButton.Size = new System.Drawing.Size(20, 21);
            this.AddNewLanguageButton.TabIndex = 6;
            this.AddNewLanguageButton.Text = "N";
            this.AddNewLanguageButton.UseVisualStyleBackColor = true;
            // 
            // TextractorLocalizationsHelper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 383);
            this.Controls.Add(this.AddNewLanguageButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.OpenButton);
            this.Controls.Add(this.TLangComboBox);
            this.Controls.Add(this.TLangLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TextractorLocalizationsHelper";
            this.Text = "Textractor Localization Helper v1.0 by Denis K<TokcDK>";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openTextcppToolStripMenuItem;
        private System.Windows.Forms.Label TLangLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        internal System.Windows.Forms.ComboBox TLangComboBox;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.ToolStripMenuItem ReadmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LinksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textractorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewLanguageToolStripMenuItem;
        private System.Windows.Forms.Button AddNewLanguageButton;
    }
}

