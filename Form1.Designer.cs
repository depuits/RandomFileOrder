namespace RandomOrder
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.clbFileList = new System.Windows.Forms.CheckedListBox();
            this.lblPath = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCheckAll = new System.Windows.Forms.Button();
            this.btnUncheckAll = new System.Windows.Forms.Button();
            this.btnInvert = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.btnRandomize = new System.Windows.Forms.Button();
            this.charsToRemoveUpDown = new System.Windows.Forms.NumericUpDown();
            this.btnRemoveDigits = new System.Windows.Forms.Button();
            this.minDigitsUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOpenDir = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.formatTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.charsToRemoveUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minDigitsUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // clbFileList
            // 
            this.clbFileList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clbFileList.CheckOnClick = true;
            this.clbFileList.FormattingEnabled = true;
            this.clbFileList.Location = new System.Drawing.Point(16, 96);
            this.clbFileList.Name = "clbFileList";
            this.clbFileList.Size = new System.Drawing.Size(307, 169);
            this.clbFileList.TabIndex = 1;
            this.clbFileList.ThreeDCheckBoxes = true;
            // 
            // lblPath
            // 
            this.lblPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPath.Location = new System.Drawing.Point(13, 9);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(310, 19);
            this.lblPath.TabIndex = 2;
            this.lblPath.Text = "no path chosen";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(16, 31);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(62, 23);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "File names to be changed:";
            // 
            // btnCheckAll
            // 
            this.btnCheckAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCheckAll.Location = new System.Drawing.Point(16, 274);
            this.btnCheckAll.Name = "btnCheckAll";
            this.btnCheckAll.Size = new System.Drawing.Size(75, 23);
            this.btnCheckAll.TabIndex = 6;
            this.btnCheckAll.Text = "Check all";
            this.btnCheckAll.UseVisualStyleBackColor = true;
            this.btnCheckAll.Click += new System.EventHandler(this.buttonCheckAll_Click);
            // 
            // btnUncheckAll
            // 
            this.btnUncheckAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUncheckAll.Location = new System.Drawing.Point(97, 274);
            this.btnUncheckAll.Name = "btnUncheckAll";
            this.btnUncheckAll.Size = new System.Drawing.Size(84, 23);
            this.btnUncheckAll.TabIndex = 7;
            this.btnUncheckAll.Text = "Uncheck all";
            this.btnUncheckAll.UseVisualStyleBackColor = true;
            this.btnUncheckAll.Click += new System.EventHandler(this.btnUncheckAll_Click);
            // 
            // btnInvert
            // 
            this.btnInvert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnInvert.Location = new System.Drawing.Point(187, 274);
            this.btnInvert.Name = "btnInvert";
            this.btnInvert.Size = new System.Drawing.Size(56, 23);
            this.btnInvert.TabIndex = 8;
            this.btnInvert.Text = "Invert";
            this.btnInvert.UseVisualStyleBackColor = true;
            this.btnInvert.Click += new System.EventHandler(this.btnInvert_Click);
            // 
            // btnRandomize
            // 
            this.btnRandomize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRandomize.Enabled = false;
            this.btnRandomize.Location = new System.Drawing.Point(187, 348);
            this.btnRandomize.Name = "btnRandomize";
            this.btnRandomize.Size = new System.Drawing.Size(136, 23);
            this.btnRandomize.TabIndex = 9;
            this.btnRandomize.Text = "Put random number at beginning of every file name";
            this.btnRandomize.UseVisualStyleBackColor = true;
            this.btnRandomize.Click += new System.EventHandler(this.btnRandomize_Click);
            // 
            // charsToRemoveUpDown
            // 
            this.charsToRemoveUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.charsToRemoveUpDown.Location = new System.Drawing.Point(16, 380);
            this.charsToRemoveUpDown.Name = "charsToRemoveUpDown";
            this.charsToRemoveUpDown.Size = new System.Drawing.Size(60, 20);
            this.charsToRemoveUpDown.TabIndex = 10;
            // 
            // btnRemoveDigits
            // 
            this.btnRemoveDigits.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveDigits.Enabled = false;
            this.btnRemoveDigits.Location = new System.Drawing.Point(82, 377);
            this.btnRemoveDigits.Name = "btnRemoveDigits";
            this.btnRemoveDigits.Size = new System.Drawing.Size(241, 23);
            this.btnRemoveDigits.TabIndex = 11;
            this.btnRemoveDigits.Text = "Remove characters from beginning of file names";
            this.btnRemoveDigits.UseVisualStyleBackColor = true;
            this.btnRemoveDigits.Click += new System.EventHandler(this.btnRemoveDigits_Click);
            // 
            // minDigitsUpDown
            // 
            this.minDigitsUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.minDigitsUpDown.Location = new System.Drawing.Point(73, 329);
            this.minDigitsUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.minDigitsUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.minDigitsUpDown.Name = "minDigitsUpDown";
            this.minDigitsUpDown.Size = new System.Drawing.Size(108, 20);
            this.minDigitsUpDown.TabIndex = 12;
            this.toolTip.SetToolTip(this.minDigitsUpDown, "Min of digits used for the number");
            this.minDigitsUpDown.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 331);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Min digits:";
            // 
            // btnOpenDir
            // 
            this.btnOpenDir.Enabled = false;
            this.btnOpenDir.Location = new System.Drawing.Point(84, 31);
            this.btnOpenDir.Name = "btnOpenDir";
            this.btnOpenDir.Size = new System.Drawing.Size(146, 23);
            this.btnOpenDir.TabIndex = 14;
            this.btnOpenDir.Text = "Open selected directory...";
            this.btnOpenDir.UseVisualStyleBackColor = true;
            this.btnOpenDir.Click += new System.EventHandler(this.btnOpenDir_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(213, 409);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(110, 13);
            this.linkLabel1.TabIndex = 15;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Visit http://lumpiluk.tk";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_Click);
            // 
            // formatTextBox
            // 
            this.formatTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.formatTextBox.Location = new System.Drawing.Point(73, 303);
            this.formatTextBox.Name = "formatTextBox";
            this.formatTextBox.Size = new System.Drawing.Size(170, 20);
            this.formatTextBox.TabIndex = 16;
            this.formatTextBox.Text = "{0} - {1}";
            this.toolTip.SetToolTip(this.formatTextBox, "{0} for the number\r\n{1} for the file name\r\ndefault \"{0} - {1}\"");
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Format:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 431);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.formatTextBox);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnOpenDir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.minDigitsUpDown);
            this.Controls.Add(this.btnRemoveDigits);
            this.Controls.Add(this.charsToRemoveUpDown);
            this.Controls.Add(this.btnRandomize);
            this.Controls.Add(this.btnInvert);
            this.Controls.Add(this.btnUncheckAll);
            this.Controls.Add(this.btnCheckAll);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.clbFileList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "FileOrderRandomizer";
            ((System.ComponentModel.ISupportInitialize)(this.charsToRemoveUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minDigitsUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbFileList;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCheckAll;
        private System.Windows.Forms.Button btnUncheckAll;
        private System.Windows.Forms.Button btnInvert;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button btnRandomize;
        private System.Windows.Forms.NumericUpDown charsToRemoveUpDown;
        private System.Windows.Forms.Button btnRemoveDigits;
        private System.Windows.Forms.NumericUpDown minDigitsUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOpenDir;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox formatTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

