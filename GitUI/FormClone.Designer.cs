namespace GitUI
{
    partial class FormClone
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Central = new System.Windows.Forms.RadioButton();
            this.Personal = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FromBrowse = new System.Windows.Forms.Button();
            this.ToBrowse = new System.Windows.Forms.Button();
            this._NO_TRANSLATE_To = new System.Windows.Forms.ComboBox();
            this._NO_TRANSLATE_From = new System.Windows.Forms.ComboBox();
            this.PersonalRepository = new System.Windows.Forms.RadioButton();
            this.CentralRepository = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._NO_TRANSLATE_NewDirectory = new System.Windows.Forms.TextBox();
            this.Info = new System.Windows.Forms.Label();
            this.brachLabel = new System.Windows.Forms.Label();
            this.Branches = new System.Windows.Forms.ComboBox();
            this.Ok = new System.Windows.Forms.Button();
            this.LoadSSHKey = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Central
            // 
            this.Central.AutoSize = true;
            this.Central.Location = new System.Drawing.Point(6, 42);
            this.Central.Name = "Central";
            this.Central.Size = new System.Drawing.Size(274, 17);
            this.Central.TabIndex = 1;
            this.Central.Text = "Central repository, no working dir  (--bare --shared=all)";
            this.Central.UseVisualStyleBackColor = true;
            // 
            // Personal
            // 
            this.Personal.AutoSize = true;
            this.Personal.Checked = true;
            this.Personal.Location = new System.Drawing.Point(6, 19);
            this.Personal.Name = "Personal";
            this.Personal.Size = new System.Drawing.Size(114, 17);
            this.Personal.TabIndex = 0;
            this.Personal.TabStop = true;
            this.Personal.Text = "Personal repository";
            this.Personal.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(21, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "From:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(40, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "To:";
            // 
            // FromBrowse
            // 
            this.FromBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FromBrowse.Location = new System.Drawing.Point(309, 22);
            this.FromBrowse.Name = "FromBrowse";
            this.FromBrowse.Size = new System.Drawing.Size(85, 25);
            this.FromBrowse.TabIndex = 2;
            this.FromBrowse.Text = "&Browse...";
            this.FromBrowse.UseVisualStyleBackColor = true;
            this.FromBrowse.Click += new System.EventHandler(this.FromBrowseClick);
            // 
            // ToBrowse
            // 
            this.ToBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ToBrowse.Location = new System.Drawing.Point(309, 92);
            this.ToBrowse.Name = "ToBrowse";
            this.ToBrowse.Size = new System.Drawing.Size(85, 25);
            this.ToBrowse.TabIndex = 5;
            this.ToBrowse.Text = "B&rowse...";
            this.ToBrowse.UseVisualStyleBackColor = true;
            this.ToBrowse.Click += new System.EventHandler(this.ToBrowseClick);
            // 
            // _NO_TRANSLATE_To
            // 
            this._NO_TRANSLATE_To.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._NO_TRANSLATE_To.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this._NO_TRANSLATE_To.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this._NO_TRANSLATE_To.FormattingEnabled = true;
            this._NO_TRANSLATE_To.Location = new System.Drawing.Point(77, 94);
            this._NO_TRANSLATE_To.Name = "_NO_TRANSLATE_To";
            this._NO_TRANSLATE_To.Size = new System.Drawing.Size(226, 23);
            this._NO_TRANSLATE_To.TabIndex = 4;
            this._NO_TRANSLATE_To.DropDown += new System.EventHandler(this.ToDropDown);
            this._NO_TRANSLATE_To.SelectedIndexChanged += new System.EventHandler(this.ToSelectedIndexChanged);
            this._NO_TRANSLATE_To.TextUpdate += new System.EventHandler(this.ToTextUpdate);
            // 
            // _NO_TRANSLATE_From
            // 
            this._NO_TRANSLATE_From.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._NO_TRANSLATE_From.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this._NO_TRANSLATE_From.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this._NO_TRANSLATE_From.FormattingEnabled = true;
            this._NO_TRANSLATE_From.Location = new System.Drawing.Point(77, 23);
            this._NO_TRANSLATE_From.Name = "_NO_TRANSLATE_From";
            this._NO_TRANSLATE_From.Size = new System.Drawing.Size(226, 23);
            this._NO_TRANSLATE_From.TabIndex = 1;
            this._NO_TRANSLATE_From.SelectedIndexChanged += new System.EventHandler(this.FromSelectedIndexChanged);
            this._NO_TRANSLATE_From.TextUpdate += new System.EventHandler(this.FromTextUpdate);
            // 
            // PersonalRepository
            // 
            this.PersonalRepository.AutoSize = true;
            this.PersonalRepository.Checked = true;
            this.PersonalRepository.Location = new System.Drawing.Point(6, 19);
            this.PersonalRepository.Name = "PersonalRepository";
            this.PersonalRepository.Size = new System.Drawing.Size(126, 19);
            this.PersonalRepository.TabIndex = 0;
            this.PersonalRepository.TabStop = true;
            this.PersonalRepository.Text = "&Personal repository";
            this.PersonalRepository.UseVisualStyleBackColor = true;
            // 
            // CentralRepository
            // 
            this.CentralRepository.AutoSize = true;
            this.CentralRepository.Location = new System.Drawing.Point(6, 42);
            this.CentralRepository.Name = "CentralRepository";
            this.CentralRepository.Size = new System.Drawing.Size(244, 19);
            this.CentralRepository.TabIndex = 1;
            this.CentralRepository.Text = "P&ublic repository, no working dir  (--bare)";
            this.CentralRepository.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CentralRepository);
            this.groupBox1.Controls.Add(this.PersonalRepository);
            this.groupBox1.Location = new System.Drawing.Point(25, 263);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 68);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Repository type";
            // 
            // _NO_TRANSLATE_NewDirectory
            // 
            this._NO_TRANSLATE_NewDirectory.Location = new System.Drawing.Point(154, 133);
            this._NO_TRANSLATE_NewDirectory.Name = "_NO_TRANSLATE_NewDirectory";
            this._NO_TRANSLATE_NewDirectory.Size = new System.Drawing.Size(128, 23);
            this._NO_TRANSLATE_NewDirectory.TabIndex = 7;
            this._NO_TRANSLATE_NewDirectory.TextChanged += new System.EventHandler(this.NewDirectoryTextChanged);
            // 
            // Info
            // 
            this.Info.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Info.BackColor = System.Drawing.SystemColors.Info;
            this.Info.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Info.Location = new System.Drawing.Point(35, 185);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(307, 42);
            this.Info.TabIndex = 10;
            this.Info.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // brachLabel
            // 
            this.brachLabel.AutoSize = true;
            this.brachLabel.Location = new System.Drawing.Point(101, 60);
            this.brachLabel.Name = "brachLabel";
            this.brachLabel.Size = new System.Drawing.Size(47, 15);
            this.brachLabel.TabIndex = 8;
            this.brachLabel.Text = "&Branch:";
            // 
            // Branches
            // 
            this.Branches.FormattingEnabled = true;
            this.Branches.Location = new System.Drawing.Point(154, 57);
            this.Branches.Name = "Branches";
            this.Branches.Size = new System.Drawing.Size(131, 23);
            this.Branches.TabIndex = 9;
            this.Branches.DropDown += new System.EventHandler(this.Branches_DropDown);
            // 
            // Ok
            // 
            this.Ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Ok.Location = new System.Drawing.Point(297, 365);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(97, 25);
            this.Ok.TabIndex = 1;
            this.Ok.Text = "Clone";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.OkClick);
            // 
            // LoadSSHKey
            // 
            this.LoadSSHKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LoadSSHKey.Image = global::GitUI.Properties.Resources.putty;
            this.LoadSSHKey.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LoadSSHKey.Location = new System.Drawing.Point(12, 365);
            this.LoadSSHKey.Name = "LoadSSHKey";
            this.LoadSSHKey.Size = new System.Drawing.Size(145, 25);
            this.LoadSSHKey.TabIndex = 0;
            this.LoadSSHKey.Text = "&Load SSH key";
            this.LoadSSHKey.UseVisualStyleBackColor = true;
            this.LoadSSHKey.Click += new System.EventHandler(this.LoadSshKeyClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "&Subdirectory:";
            // 
            // FormClone
            // 
            this.AcceptButton = this.Ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 402);
            this.Controls.Add(this.LoadSSHKey);
            this.Controls.Add(this.Branches);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.brachLabel);
            this.Controls.Add(this.FromBrowse);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.ToBrowse);
            this.Controls.Add(this._NO_TRANSLATE_NewDirectory);
            this.Controls.Add(this._NO_TRANSLATE_To);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._NO_TRANSLATE_From);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(633, 500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(430, 440);
            this.Name = "FormClone";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Clone";
            this.Load += new System.EventHandler(this.FormCloneLoad);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton Central;
        private System.Windows.Forms.RadioButton Personal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button FromBrowse;
        private System.Windows.Forms.Button ToBrowse;
        private System.Windows.Forms.ComboBox _NO_TRANSLATE_To;
        private System.Windows.Forms.ComboBox _NO_TRANSLATE_From;
        private System.Windows.Forms.RadioButton PersonalRepository;
        private System.Windows.Forms.RadioButton CentralRepository;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox _NO_TRANSLATE_NewDirectory;
        private System.Windows.Forms.Label Info;
        private System.Windows.Forms.Label brachLabel;
        private System.Windows.Forms.ComboBox Branches;
        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.Button LoadSSHKey;
        private System.Windows.Forms.Label label3;
    }
}
