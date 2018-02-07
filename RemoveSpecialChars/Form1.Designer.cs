namespace RemoveSpecialChars
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
            this.gbxRemoveAllChars = new System.Windows.Forms.GroupBox();
            this.lSpecificChar = new System.Windows.Forms.Label();
            this.tbxSpecificchar = new System.Windows.Forms.TextBox();
            this.cbxRemoveSpecificChars = new System.Windows.Forms.CheckBox();
            this.cbxEmptySpace = new System.Windows.Forms.CheckBox();
            this.cbxTab = new System.Windows.Forms.CheckBox();
            this.cbxCarriageReturn = new System.Windows.Forms.CheckBox();
            this.cbxNewLine = new System.Windows.Forms.CheckBox();
            this.tbxOG = new System.Windows.Forms.TextBox();
            this.lOG = new System.Windows.Forms.Label();
            this.lOutput = new System.Windows.Forms.Label();
            this.tbxOutput = new System.Windows.Forms.TextBox();
            this.btnProcess = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.gbxLoadData = new System.Windows.Forms.GroupBox();
            this.loadFileMinimise = new System.Windows.Forms.Button();
            this.btnSetOutput = new System.Windows.Forms.Button();
            this.lFilePathOutput = new System.Windows.Forms.Label();
            this.tbxFilePathOutput = new System.Windows.Forms.TextBox();
            this.lFilePathSource = new System.Windows.Forms.Label();
            this.tbxFilePathSource = new System.Windows.Forms.TextBox();
            this.gbxFormat = new System.Windows.Forms.GroupBox();
            this.txbEndTag = new System.Windows.Forms.TextBox();
            this.cbxEndTag = new System.Windows.Forms.CheckBox();
            this.cbxApostrophe = new System.Windows.Forms.CheckBox();
            this.cbxAddforwardSlash = new System.Windows.Forms.CheckBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.txboxBase64 = new System.Windows.Forms.TextBox();
            this.lBase64encoding = new System.Windows.Forms.Label();
            this.chkDefults = new System.Windows.Forms.CheckBox();
            this.gbxRemoveAllChars.SuspendLayout();
            this.gbxLoadData.SuspendLayout();
            this.gbxFormat.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxRemoveAllChars
            // 
            this.gbxRemoveAllChars.Controls.Add(this.lSpecificChar);
            this.gbxRemoveAllChars.Controls.Add(this.tbxSpecificchar);
            this.gbxRemoveAllChars.Controls.Add(this.cbxRemoveSpecificChars);
            this.gbxRemoveAllChars.Controls.Add(this.cbxEmptySpace);
            this.gbxRemoveAllChars.Controls.Add(this.cbxTab);
            this.gbxRemoveAllChars.Controls.Add(this.cbxCarriageReturn);
            this.gbxRemoveAllChars.Controls.Add(this.cbxNewLine);
            this.gbxRemoveAllChars.Location = new System.Drawing.Point(15, 181);
            this.gbxRemoveAllChars.Name = "gbxRemoveAllChars";
            this.gbxRemoveAllChars.Size = new System.Drawing.Size(278, 145);
            this.gbxRemoveAllChars.TabIndex = 5;
            this.gbxRemoveAllChars.TabStop = false;
            this.gbxRemoveAllChars.Text = "Remove Character";
            // 
            // lSpecificChar
            // 
            this.lSpecificChar.AutoSize = true;
            this.lSpecificChar.Location = new System.Drawing.Point(30, 114);
            this.lSpecificChar.Name = "lSpecificChar";
            this.lSpecificChar.Size = new System.Drawing.Size(70, 13);
            this.lSpecificChar.TabIndex = 11;
            this.lSpecificChar.Text = "Specific Char";
            // 
            // tbxSpecificchar
            // 
            this.tbxSpecificchar.Location = new System.Drawing.Point(106, 111);
            this.tbxSpecificchar.Name = "tbxSpecificchar";
            this.tbxSpecificchar.Size = new System.Drawing.Size(53, 20);
            this.tbxSpecificchar.TabIndex = 9;
            this.tbxSpecificchar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cbxRemoveSpecificChars
            // 
            this.cbxRemoveSpecificChars.AutoSize = true;
            this.cbxRemoveSpecificChars.Location = new System.Drawing.Point(6, 88);
            this.cbxRemoveSpecificChars.Name = "cbxRemoveSpecificChars";
            this.cbxRemoveSpecificChars.Size = new System.Drawing.Size(259, 17);
            this.cbxRemoveSpecificChars.TabIndex = 8;
            this.cbxRemoveSpecificChars.Text = "Remove Empty Space Not between specific char";
            this.cbxRemoveSpecificChars.UseVisualStyleBackColor = true;
            this.cbxRemoveSpecificChars.CheckedChanged += new System.EventHandler(this.cbxRemoveSpecificChars_CheckedChanged);
            // 
            // cbxEmptySpace
            // 
            this.cbxEmptySpace.AutoSize = true;
            this.cbxEmptySpace.Location = new System.Drawing.Point(6, 56);
            this.cbxEmptySpace.Name = "cbxEmptySpace";
            this.cbxEmptySpace.Size = new System.Drawing.Size(159, 17);
            this.cbxEmptySpace.TabIndex = 7;
            this.cbxEmptySpace.Text = "Remove All EmptySpace \" \"";
            this.cbxEmptySpace.UseVisualStyleBackColor = true;
            // 
            // cbxTab
            // 
            this.cbxTab.AutoSize = true;
            this.cbxTab.Location = new System.Drawing.Point(6, 19);
            this.cbxTab.Name = "cbxTab";
            this.cbxTab.Size = new System.Drawing.Size(66, 17);
            this.cbxTab.TabIndex = 6;
            this.cbxTab.Text = "Tab \"\\t\"";
            this.cbxTab.UseVisualStyleBackColor = true;
            // 
            // cbxCarriageReturn
            // 
            this.cbxCarriageReturn.AutoSize = true;
            this.cbxCarriageReturn.Location = new System.Drawing.Point(144, 19);
            this.cbxCarriageReturn.Name = "cbxCarriageReturn";
            this.cbxCarriageReturn.Size = new System.Drawing.Size(121, 17);
            this.cbxCarriageReturn.TabIndex = 5;
            this.cbxCarriageReturn.Text = "Carriage Return \"\\r\"";
            this.cbxCarriageReturn.UseVisualStyleBackColor = true;
            // 
            // cbxNewLine
            // 
            this.cbxNewLine.AutoSize = true;
            this.cbxNewLine.Location = new System.Drawing.Point(174, 56);
            this.cbxNewLine.Name = "cbxNewLine";
            this.cbxNewLine.Size = new System.Drawing.Size(91, 17);
            this.cbxNewLine.TabIndex = 4;
            this.cbxNewLine.Text = "New line \"\\n\"";
            this.cbxNewLine.UseVisualStyleBackColor = true;
            // 
            // tbxOG
            // 
            this.tbxOG.Location = new System.Drawing.Point(6, 498);
            this.tbxOG.MaxLength = 9999999;
            this.tbxOG.Multiline = true;
            this.tbxOG.Name = "tbxOG";
            this.tbxOG.Size = new System.Drawing.Size(383, 50);
            this.tbxOG.TabIndex = 6;
            this.tbxOG.TextChanged += new System.EventHandler(this.tbxOG_TextChanged);
            // 
            // lOG
            // 
            this.lOG.AutoSize = true;
            this.lOG.Location = new System.Drawing.Point(3, 482);
            this.lOG.Name = "lOG";
            this.lOG.Size = new System.Drawing.Size(68, 13);
            this.lOG.TabIndex = 7;
            this.lOG.Text = "Original Data";
            // 
            // lOutput
            // 
            this.lOutput.AutoSize = true;
            this.lOutput.Location = new System.Drawing.Point(6, 551);
            this.lOutput.Name = "lOutput";
            this.lOutput.Size = new System.Drawing.Size(39, 13);
            this.lOutput.TabIndex = 8;
            this.lOutput.Text = "Output";
            this.lOutput.Click += new System.EventHandler(this.lOutput_Click);
            // 
            // tbxOutput
            // 
            this.tbxOutput.Location = new System.Drawing.Point(9, 577);
            this.tbxOutput.MaxLength = 500000;
            this.tbxOutput.Multiline = true;
            this.tbxOutput.Name = "tbxOutput";
            this.tbxOutput.Size = new System.Drawing.Size(380, 64);
            this.tbxOutput.TabIndex = 9;
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(15, 668);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(73, 24);
            this.btnProcess.TabIndex = 10;
            this.btnProcess.Text = "Process";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(3, 47);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 11;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // gbxLoadData
            // 
            this.gbxLoadData.Controls.Add(this.loadFileMinimise);
            this.gbxLoadData.Controls.Add(this.btnSetOutput);
            this.gbxLoadData.Controls.Add(this.lFilePathOutput);
            this.gbxLoadData.Controls.Add(this.tbxFilePathOutput);
            this.gbxLoadData.Controls.Add(this.lFilePathSource);
            this.gbxLoadData.Controls.Add(this.tbxFilePathSource);
            this.gbxLoadData.Controls.Add(this.btnBrowse);
            this.gbxLoadData.Location = new System.Drawing.Point(6, 338);
            this.gbxLoadData.Name = "gbxLoadData";
            this.gbxLoadData.Size = new System.Drawing.Size(496, 141);
            this.gbxLoadData.TabIndex = 12;
            this.gbxLoadData.TabStop = false;
            this.gbxLoadData.Text = "Load Data From File";
            // 
            // loadFileMinimise
            // 
            this.loadFileMinimise.Location = new System.Drawing.Point(437, 0);
            this.loadFileMinimise.Name = "loadFileMinimise";
            this.loadFileMinimise.Size = new System.Drawing.Size(23, 23);
            this.loadFileMinimise.TabIndex = 17;
            this.loadFileMinimise.Text = "-";
            this.loadFileMinimise.UseVisualStyleBackColor = true;
            this.loadFileMinimise.Click += new System.EventHandler(this.loadFileMinimise_Click);
            // 
            // btnSetOutput
            // 
            this.btnSetOutput.Location = new System.Drawing.Point(6, 98);
            this.btnSetOutput.Name = "btnSetOutput";
            this.btnSetOutput.Size = new System.Drawing.Size(74, 22);
            this.btnSetOutput.TabIndex = 16;
            this.btnSetOutput.Text = "Set Output";
            this.btnSetOutput.UseVisualStyleBackColor = true;
            this.btnSetOutput.Click += new System.EventHandler(this.btnSetOutput_Click);
            // 
            // lFilePathOutput
            // 
            this.lFilePathOutput.AutoSize = true;
            this.lFilePathOutput.Location = new System.Drawing.Point(112, 82);
            this.lFilePathOutput.Name = "lFilePathOutput";
            this.lFilePathOutput.Size = new System.Drawing.Size(83, 13);
            this.lFilePathOutput.TabIndex = 15;
            this.lFilePathOutput.Text = "File Path Output";
            // 
            // tbxFilePathOutput
            // 
            this.tbxFilePathOutput.Location = new System.Drawing.Point(115, 100);
            this.tbxFilePathOutput.Name = "tbxFilePathOutput";
            this.tbxFilePathOutput.Size = new System.Drawing.Size(369, 20);
            this.tbxFilePathOutput.TabIndex = 14;
            // 
            // lFilePathSource
            // 
            this.lFilePathSource.AutoSize = true;
            this.lFilePathSource.Location = new System.Drawing.Point(112, 31);
            this.lFilePathSource.Name = "lFilePathSource";
            this.lFilePathSource.Size = new System.Drawing.Size(85, 13);
            this.lFilePathSource.TabIndex = 13;
            this.lFilePathSource.Text = "File Path Source";
            // 
            // tbxFilePathSource
            // 
            this.tbxFilePathSource.Location = new System.Drawing.Point(115, 47);
            this.tbxFilePathSource.Name = "tbxFilePathSource";
            this.tbxFilePathSource.Size = new System.Drawing.Size(369, 20);
            this.tbxFilePathSource.TabIndex = 12;
            // 
            // gbxFormat
            // 
            this.gbxFormat.Controls.Add(this.txbEndTag);
            this.gbxFormat.Controls.Add(this.cbxEndTag);
            this.gbxFormat.Controls.Add(this.cbxApostrophe);
            this.gbxFormat.Controls.Add(this.cbxAddforwardSlash);
            this.gbxFormat.Location = new System.Drawing.Point(319, 201);
            this.gbxFormat.Name = "gbxFormat";
            this.gbxFormat.Size = new System.Drawing.Size(223, 131);
            this.gbxFormat.TabIndex = 13;
            this.gbxFormat.TabStop = false;
            this.gbxFormat.Text = "Format";
            // 
            // txbEndTag
            // 
            this.txbEndTag.Location = new System.Drawing.Point(35, 105);
            this.txbEndTag.Name = "txbEndTag";
            this.txbEndTag.Size = new System.Drawing.Size(168, 20);
            this.txbEndTag.TabIndex = 3;
            this.txbEndTag.Text = "</EndTag>";
            // 
            // cbxEndTag
            // 
            this.cbxEndTag.AutoSize = true;
            this.cbxEndTag.Location = new System.Drawing.Point(6, 87);
            this.cbxEndTag.Name = "cbxEndTag";
            this.cbxEndTag.Size = new System.Drawing.Size(197, 17);
            this.cbxEndTag.TabIndex = 2;
            this.cbxEndTag.Text = "Add New line after specified end tag";
            this.cbxEndTag.UseVisualStyleBackColor = true;
            this.cbxEndTag.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cbxApostrophe
            // 
            this.cbxApostrophe.AutoSize = true;
            this.cbxApostrophe.Location = new System.Drawing.Point(6, 55);
            this.cbxApostrophe.Name = "cbxApostrophe";
            this.cbxApostrophe.Size = new System.Drawing.Size(141, 17);
            this.cbxApostrophe.TabIndex = 1;
            this.cbxApostrophe.Text = "Add \" \' \" for Apostrophe ";
            this.cbxApostrophe.UseVisualStyleBackColor = true;
            // 
            // cbxAddforwardSlash
            // 
            this.cbxAddforwardSlash.AutoSize = true;
            this.cbxAddforwardSlash.Location = new System.Drawing.Point(6, 22);
            this.cbxAddforwardSlash.Name = "cbxAddforwardSlash";
            this.cbxAddforwardSlash.Size = new System.Drawing.Size(158, 17);
            this.cbxAddforwardSlash.TabIndex = 0;
            this.cbxAddforwardSlash.Text = "Add \"\\\" for Quotation marks";
            this.cbxAddforwardSlash.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(427, 496);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(427, 582);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(74, 58);
            this.btnCopy.TabIndex = 15;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // txboxBase64
            // 
            this.txboxBase64.AllowDrop = true;
            this.txboxBase64.Location = new System.Drawing.Point(21, 25);
            this.txboxBase64.Multiline = true;
            this.txboxBase64.Name = "txboxBase64";
            this.txboxBase64.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txboxBase64.Size = new System.Drawing.Size(491, 95);
            this.txboxBase64.TabIndex = 16;
            this.txboxBase64.Text = "Drag and Drop File ....";
            this.txboxBase64.DragDrop += new System.Windows.Forms.DragEventHandler(this.txboxBase64_DragDrop);
            this.txboxBase64.DragEnter += new System.Windows.Forms.DragEventHandler(this.txboxBase64_DragEnter);
            this.txboxBase64.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txboxBase64_KeyDown);
            // 
            // lBase64encoding
            // 
            this.lBase64encoding.AutoSize = true;
            this.lBase64encoding.Location = new System.Drawing.Point(18, 9);
            this.lBase64encoding.Name = "lBase64encoding";
            this.lBase64encoding.Size = new System.Drawing.Size(236, 13);
            this.lBase64encoding.TabIndex = 17;
            this.lBase64encoding.Text = "Drag and drop an .PNG file for Base64 encoding";
            // 
            // chkDefults
            // 
            this.chkDefults.AutoSize = true;
            this.chkDefults.Location = new System.Drawing.Point(21, 143);
            this.chkDefults.Name = "chkDefults";
            this.chkDefults.Size = new System.Drawing.Size(142, 17);
            this.chkDefults.TabIndex = 18;
            this.chkDefults.Text = "Set ticket layout defaults";
            this.chkDefults.UseVisualStyleBackColor = true;
            this.chkDefults.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 713);
            this.Controls.Add(this.chkDefults);
            this.Controls.Add(this.lBase64encoding);
            this.Controls.Add(this.txboxBase64);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.gbxFormat);
            this.Controls.Add(this.gbxLoadData);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.tbxOutput);
            this.Controls.Add(this.lOutput);
            this.Controls.Add(this.lOG);
            this.Controls.Add(this.tbxOG);
            this.Controls.Add(this.gbxRemoveAllChars);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbxRemoveAllChars.ResumeLayout(false);
            this.gbxRemoveAllChars.PerformLayout();
            this.gbxLoadData.ResumeLayout(false);
            this.gbxLoadData.PerformLayout();
            this.gbxFormat.ResumeLayout(false);
            this.gbxFormat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxRemoveAllChars;
        private System.Windows.Forms.CheckBox cbxEmptySpace;
        private System.Windows.Forms.CheckBox cbxTab;
        private System.Windows.Forms.CheckBox cbxCarriageReturn;
        private System.Windows.Forms.CheckBox cbxNewLine;
        private System.Windows.Forms.TextBox tbxOG;
        private System.Windows.Forms.Label lOG;
        private System.Windows.Forms.Label lOutput;
        private System.Windows.Forms.TextBox tbxOutput;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.GroupBox gbxLoadData;
        private System.Windows.Forms.Label lFilePathOutput;
        private System.Windows.Forms.TextBox tbxFilePathOutput;
        private System.Windows.Forms.Label lFilePathSource;
        private System.Windows.Forms.TextBox tbxFilePathSource;
        private System.Windows.Forms.Button btnSetOutput;
        private System.Windows.Forms.GroupBox gbxFormat;
        private System.Windows.Forms.CheckBox cbxAddforwardSlash;
        private System.Windows.Forms.CheckBox cbxApostrophe;
        private System.Windows.Forms.Label lSpecificChar;
        private System.Windows.Forms.TextBox tbxSpecificchar;
        private System.Windows.Forms.CheckBox cbxRemoveSpecificChars;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.CheckBox cbxEndTag;
        private System.Windows.Forms.TextBox txbEndTag;
        private System.Windows.Forms.TextBox txboxBase64;
        private System.Windows.Forms.Button loadFileMinimise;
        private System.Windows.Forms.Label lBase64encoding;
        private System.Windows.Forms.CheckBox chkDefults;
    }
}

