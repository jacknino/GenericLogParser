namespace GenericLogParser
{
    partial class SaveOptionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaveOptionsForm));
            this.textBoxOutputFile = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonSelectOutputFile = new System.Windows.Forms.Button();
            this.groupBoxItemsToSave = new System.Windows.Forms.GroupBox();
            this.checkBoxSaveOutputFormat = new System.Windows.Forms.CheckBox();
            this.checkBoxSaveInputFormat = new System.Windows.Forms.CheckBox();
            this.checkBoxSaveExcludeStatements = new System.Windows.Forms.CheckBox();
            this.checkBoxSaveIncludeStatements = new System.Windows.Forms.CheckBox();
            this.checkBoxSaveHeaderExpression = new System.Windows.Forms.CheckBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBoxItemsToSave.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxOutputFile
            // 
            this.textBoxOutputFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOutputFile.Location = new System.Drawing.Point(70, 12);
            this.textBoxOutputFile.Name = "textBoxOutputFile";
            this.textBoxOutputFile.Size = new System.Drawing.Size(581, 20);
            this.textBoxOutputFile.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Output File";
            // 
            // buttonSelectOutputFile
            // 
            this.buttonSelectOutputFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSelectOutputFile.Location = new System.Drawing.Point(657, 12);
            this.buttonSelectOutputFile.Name = "buttonSelectOutputFile";
            this.buttonSelectOutputFile.Size = new System.Drawing.Size(24, 20);
            this.buttonSelectOutputFile.TabIndex = 25;
            this.buttonSelectOutputFile.Text = "&...";
            this.buttonSelectOutputFile.Click += new System.EventHandler(this.buttonSelectOutputFile_Click);
            // 
            // groupBoxItemsToSave
            // 
            this.groupBoxItemsToSave.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxItemsToSave.Controls.Add(this.checkBoxSaveOutputFormat);
            this.groupBoxItemsToSave.Controls.Add(this.checkBoxSaveInputFormat);
            this.groupBoxItemsToSave.Controls.Add(this.checkBoxSaveExcludeStatements);
            this.groupBoxItemsToSave.Controls.Add(this.checkBoxSaveIncludeStatements);
            this.groupBoxItemsToSave.Controls.Add(this.checkBoxSaveHeaderExpression);
            this.groupBoxItemsToSave.Location = new System.Drawing.Point(13, 45);
            this.groupBoxItemsToSave.Name = "groupBoxItemsToSave";
            this.groupBoxItemsToSave.Size = new System.Drawing.Size(665, 156);
            this.groupBoxItemsToSave.TabIndex = 1;
            this.groupBoxItemsToSave.TabStop = false;
            this.groupBoxItemsToSave.Text = "Options To Save";
            // 
            // checkBoxSaveOutputFormat
            // 
            this.checkBoxSaveOutputFormat.AutoSize = true;
            this.checkBoxSaveOutputFormat.Checked = true;
            this.checkBoxSaveOutputFormat.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSaveOutputFormat.Location = new System.Drawing.Point(15, 111);
            this.checkBoxSaveOutputFormat.Name = "checkBoxSaveOutputFormat";
            this.checkBoxSaveOutputFormat.Size = new System.Drawing.Size(93, 17);
            this.checkBoxSaveOutputFormat.TabIndex = 4;
            this.checkBoxSaveOutputFormat.Text = "O&utput Format";
            this.checkBoxSaveOutputFormat.UseVisualStyleBackColor = true;
            // 
            // checkBoxSaveInputFormat
            // 
            this.checkBoxSaveInputFormat.AutoSize = true;
            this.checkBoxSaveInputFormat.Checked = true;
            this.checkBoxSaveInputFormat.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSaveInputFormat.Location = new System.Drawing.Point(15, 88);
            this.checkBoxSaveInputFormat.Name = "checkBoxSaveInputFormat";
            this.checkBoxSaveInputFormat.Size = new System.Drawing.Size(85, 17);
            this.checkBoxSaveInputFormat.TabIndex = 3;
            this.checkBoxSaveInputFormat.Text = "I&nput Format";
            this.checkBoxSaveInputFormat.UseVisualStyleBackColor = true;
            // 
            // checkBoxSaveExcludeStatements
            // 
            this.checkBoxSaveExcludeStatements.AutoSize = true;
            this.checkBoxSaveExcludeStatements.Checked = true;
            this.checkBoxSaveExcludeStatements.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSaveExcludeStatements.Location = new System.Drawing.Point(15, 65);
            this.checkBoxSaveExcludeStatements.Name = "checkBoxSaveExcludeStatements";
            this.checkBoxSaveExcludeStatements.Size = new System.Drawing.Size(117, 17);
            this.checkBoxSaveExcludeStatements.TabIndex = 2;
            this.checkBoxSaveExcludeStatements.Text = "E&xcludeStatements";
            this.checkBoxSaveExcludeStatements.UseVisualStyleBackColor = true;
            // 
            // checkBoxSaveIncludeStatements
            // 
            this.checkBoxSaveIncludeStatements.AutoSize = true;
            this.checkBoxSaveIncludeStatements.Checked = true;
            this.checkBoxSaveIncludeStatements.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSaveIncludeStatements.Location = new System.Drawing.Point(15, 42);
            this.checkBoxSaveIncludeStatements.Name = "checkBoxSaveIncludeStatements";
            this.checkBoxSaveIncludeStatements.Size = new System.Drawing.Size(117, 17);
            this.checkBoxSaveIncludeStatements.TabIndex = 1;
            this.checkBoxSaveIncludeStatements.Text = "&Include Statements";
            this.checkBoxSaveIncludeStatements.UseVisualStyleBackColor = true;
            // 
            // checkBoxSaveHeaderExpression
            // 
            this.checkBoxSaveHeaderExpression.AutoSize = true;
            this.checkBoxSaveHeaderExpression.Checked = true;
            this.checkBoxSaveHeaderExpression.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSaveHeaderExpression.Location = new System.Drawing.Point(15, 19);
            this.checkBoxSaveHeaderExpression.Name = "checkBoxSaveHeaderExpression";
            this.checkBoxSaveHeaderExpression.Size = new System.Drawing.Size(115, 17);
            this.checkBoxSaveHeaderExpression.TabIndex = 0;
            this.checkBoxSaveHeaderExpression.Text = "&Header Expression";
            this.checkBoxSaveHeaderExpression.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Location = new System.Drawing.Point(522, 207);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 2;
            this.buttonOK.Text = "&OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(603, 207);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "&Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // SaveOptionsForm
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(690, 237);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.groupBoxItemsToSave);
            this.Controls.Add(this.textBoxOutputFile);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonSelectOutputFile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "SaveOptionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Save Parse Options";
            this.groupBoxItemsToSave.ResumeLayout(false);
            this.groupBoxItemsToSave.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxOutputFile;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonSelectOutputFile;
        private System.Windows.Forms.GroupBox groupBoxItemsToSave;
        private System.Windows.Forms.CheckBox checkBoxSaveOutputFormat;
        private System.Windows.Forms.CheckBox checkBoxSaveInputFormat;
        private System.Windows.Forms.CheckBox checkBoxSaveExcludeStatements;
        private System.Windows.Forms.CheckBox checkBoxSaveIncludeStatements;
        private System.Windows.Forms.CheckBox checkBoxSaveHeaderExpression;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
    }
}