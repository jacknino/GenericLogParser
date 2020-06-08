namespace GenericLogParser
{
    partial class EditOptionsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditOptionsForm));
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxStatementsToInclude = new System.Windows.Forms.ListBox();
            this.buttonApplyFilter = new System.Windows.Forms.Button();
            this.buttonAddIncludeStatementToList = new System.Windows.Forms.Button();
            this.buttonClearIncludeList = new System.Windows.Forms.Button();
            this.richTextSampleInput = new System.Windows.Forms.RichTextBox();
            this.textBoxSearchIncludeText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonChooseHeader = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonClearExcludeList = new System.Windows.Forms.Button();
            this.listBoxStatementsToExclude = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxSearchExcludeText = new System.Windows.Forms.TextBox();
            this.buttonAddExcludeStatementToList = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxInputFormat = new System.Windows.Forms.TextBox();
            this.textBoxOutputFormat = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonSaveOptions = new System.Windows.Forms.Button();
            this.textBoxHeaderRowSearchExpression = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxOutputFileSuffix = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.richTextSampleOutput = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Statements To Include";
            // 
            // listBoxStatementsToInclude
            // 
            this.listBoxStatementsToInclude.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxStatementsToInclude.HorizontalScrollbar = true;
            this.listBoxStatementsToInclude.Location = new System.Drawing.Point(12, 111);
            this.listBoxStatementsToInclude.Name = "listBoxStatementsToInclude";
            this.listBoxStatementsToInclude.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxStatementsToInclude.Size = new System.Drawing.Size(616, 95);
            this.listBoxStatementsToInclude.TabIndex = 9;
            this.listBoxStatementsToInclude.KeyUp += new System.Windows.Forms.KeyEventHandler(this.listBoxSearches_KeyUp);
            // 
            // buttonApplyFilter
            // 
            this.buttonApplyFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonApplyFilter.Location = new System.Drawing.Point(640, 375);
            this.buttonApplyFilter.Name = "buttonApplyFilter";
            this.buttonApplyFilter.Size = new System.Drawing.Size(108, 24);
            this.buttonApplyFilter.TabIndex = 18;
            this.buttonApplyFilter.Text = "Apply &Filter";
            this.buttonApplyFilter.Click += new System.EventHandler(this.buttonApplyFilter_Click);
            // 
            // buttonAddIncludeStatementToList
            // 
            this.buttonAddIncludeStatementToList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddIncludeStatementToList.Location = new System.Drawing.Point(640, 68);
            this.buttonAddIncludeStatementToList.Name = "buttonAddIncludeStatementToList";
            this.buttonAddIncludeStatementToList.Size = new System.Drawing.Size(108, 24);
            this.buttonAddIncludeStatementToList.TabIndex = 8;
            this.buttonAddIncludeStatementToList.Text = "&Add To List";
            this.buttonAddIncludeStatementToList.Click += new System.EventHandler(this.buttonAddIncludeStatementToList_Click);
            // 
            // buttonClearIncludeList
            // 
            this.buttonClearIncludeList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClearIncludeList.Location = new System.Drawing.Point(640, 111);
            this.buttonClearIncludeList.Name = "buttonClearIncludeList";
            this.buttonClearIncludeList.Size = new System.Drawing.Size(108, 24);
            this.buttonClearIncludeList.TabIndex = 10;
            this.buttonClearIncludeList.Text = "&Clear List";
            this.buttonClearIncludeList.Click += new System.EventHandler(this.buttonClearIncludeList_Click);
            // 
            // richTextSampleInput
            // 
            this.richTextSampleInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextSampleInput.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextSampleInput.Location = new System.Drawing.Point(12, 427);
            this.richTextSampleInput.Name = "richTextSampleInput";
            this.richTextSampleInput.Size = new System.Drawing.Size(736, 138);
            this.richTextSampleInput.TabIndex = 19;
            this.richTextSampleInput.Text = "";
            this.richTextSampleInput.WordWrap = false;
            // 
            // textBoxSearchIncludeText
            // 
            this.textBoxSearchIncludeText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearchIncludeText.Location = new System.Drawing.Point(68, 71);
            this.textBoxSearchIncludeText.Name = "textBoxSearchIncludeText";
            this.textBoxSearchIncludeText.Size = new System.Drawing.Size(560, 20);
            this.textBoxSearchIncludeText.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Include";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 32);
            this.label4.TabIndex = 35;
            this.label4.Text = "Header Expression";
            // 
            // buttonChooseHeader
            // 
            this.buttonChooseHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonChooseHeader.Location = new System.Drawing.Point(640, 40);
            this.buttonChooseHeader.Name = "buttonChooseHeader";
            this.buttonChooseHeader.Size = new System.Drawing.Size(108, 24);
            this.buttonChooseHeader.TabIndex = 6;
            this.buttonChooseHeader.Text = "Choose &Header...";
            this.buttonChooseHeader.Click += new System.EventHandler(this.buttonChooseHeader_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Statements To Exclude";
            // 
            // buttonClearExcludeList
            // 
            this.buttonClearExcludeList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClearExcludeList.Location = new System.Drawing.Point(640, 253);
            this.buttonClearExcludeList.Name = "buttonClearExcludeList";
            this.buttonClearExcludeList.Size = new System.Drawing.Size(108, 24);
            this.buttonClearExcludeList.TabIndex = 14;
            this.buttonClearExcludeList.Text = "Clea&r List";
            this.buttonClearExcludeList.Click += new System.EventHandler(this.buttonClearExcludeList_Click);
            // 
            // listBoxStatementsToExclude
            // 
            this.listBoxStatementsToExclude.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxStatementsToExclude.HorizontalScrollbar = true;
            this.listBoxStatementsToExclude.Location = new System.Drawing.Point(12, 253);
            this.listBoxStatementsToExclude.Name = "listBoxStatementsToExclude";
            this.listBoxStatementsToExclude.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxStatementsToExclude.Size = new System.Drawing.Size(616, 95);
            this.listBoxStatementsToExclude.TabIndex = 13;
            this.listBoxStatementsToExclude.KeyUp += new System.Windows.Forms.KeyEventHandler(this.listBoxSearches_KeyUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "Exclude";
            // 
            // textBoxSearchExcludeText
            // 
            this.textBoxSearchExcludeText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearchExcludeText.Location = new System.Drawing.Point(68, 213);
            this.textBoxSearchExcludeText.Name = "textBoxSearchExcludeText";
            this.textBoxSearchExcludeText.Size = new System.Drawing.Size(560, 20);
            this.textBoxSearchExcludeText.TabIndex = 11;
            // 
            // buttonAddExcludeStatementToList
            // 
            this.buttonAddExcludeStatementToList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddExcludeStatementToList.Location = new System.Drawing.Point(640, 210);
            this.buttonAddExcludeStatementToList.Name = "buttonAddExcludeStatementToList";
            this.buttonAddExcludeStatementToList.Size = new System.Drawing.Size(108, 24);
            this.buttonAddExcludeStatementToList.TabIndex = 12;
            this.buttonAddExcludeStatementToList.Text = "Add To &List";
            this.buttonAddExcludeStatementToList.Click += new System.EventHandler(this.buttonAddExcludeStatementToList_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 355);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 42;
            this.label7.Text = "Input Format";
            // 
            // textBoxInputFormat
            // 
            this.textBoxInputFormat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxInputFormat.Location = new System.Drawing.Point(92, 352);
            this.textBoxInputFormat.Name = "textBoxInputFormat";
            this.textBoxInputFormat.Size = new System.Drawing.Size(536, 20);
            this.textBoxInputFormat.TabIndex = 15;
            // 
            // textBoxOutputFormat
            // 
            this.textBoxOutputFormat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOutputFormat.Location = new System.Drawing.Point(92, 378);
            this.textBoxOutputFormat.Name = "textBoxOutputFormat";
            this.textBoxOutputFormat.Size = new System.Drawing.Size(536, 20);
            this.textBoxOutputFormat.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 381);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 44;
            this.label9.Text = "Output Format";
            // 
            // buttonSaveOptions
            // 
            this.buttonSaveOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveOptions.Location = new System.Drawing.Point(640, 299);
            this.buttonSaveOptions.Name = "buttonSaveOptions";
            this.buttonSaveOptions.Size = new System.Drawing.Size(108, 24);
            this.buttonSaveOptions.TabIndex = 45;
            this.buttonSaveOptions.Text = "&Save Options...";
            this.buttonSaveOptions.Click += new System.EventHandler(this.buttonSaveOptions_Click);
            // 
            // textBoxHeaderRowSearchExpression
            // 
            this.textBoxHeaderRowSearchExpression.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxHeaderRowSearchExpression.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::GenericLogParser.Properties.Settings.Default, "LastHeaderSearchExpression", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxHeaderRowSearchExpression.Location = new System.Drawing.Point(68, 43);
            this.textBoxHeaderRowSearchExpression.Name = "textBoxHeaderRowSearchExpression";
            this.textBoxHeaderRowSearchExpression.Size = new System.Drawing.Size(560, 20);
            this.textBoxHeaderRowSearchExpression.TabIndex = 5;
            this.textBoxHeaderRowSearchExpression.Text = global::GenericLogParser.Properties.Settings.Default.LastHeaderSearchExpression;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(13, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 32);
            this.label10.TabIndex = 48;
            this.label10.Text = "Output File Suffix";
            // 
            // textBoxOutputFileSuffix
            // 
            this.textBoxOutputFileSuffix.Location = new System.Drawing.Point(68, 17);
            this.textBoxOutputFileSuffix.Name = "textBoxOutputFileSuffix";
            this.textBoxOutputFileSuffix.Size = new System.Drawing.Size(560, 20);
            this.textBoxOutputFileSuffix.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 411);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "Sample Input";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 575);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 51;
            this.label8.Text = "Sample Output";
            // 
            // richTextSampleOutput
            // 
            this.richTextSampleOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextSampleOutput.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextSampleOutput.Location = new System.Drawing.Point(12, 591);
            this.richTextSampleOutput.Name = "richTextSampleOutput";
            this.richTextSampleOutput.Size = new System.Drawing.Size(736, 148);
            this.richTextSampleOutput.TabIndex = 50;
            this.richTextSampleOutput.Text = "";
            this.richTextSampleOutput.WordWrap = false;
            // 
            // EditOptionsForm
            // 
            this.AcceptButton = this.buttonApplyFilter;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(756, 751);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.richTextSampleOutput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxOutputFileSuffix);
            this.Controls.Add(this.buttonSaveOptions);
            this.Controls.Add(this.textBoxOutputFormat);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxInputFormat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxSearchExcludeText);
            this.Controls.Add(this.buttonAddExcludeStatementToList);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonClearExcludeList);
            this.Controls.Add(this.listBoxStatementsToExclude);
            this.Controls.Add(this.buttonChooseHeader);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxHeaderRowSearchExpression);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxSearchIncludeText);
            this.Controls.Add(this.richTextSampleInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonClearIncludeList);
            this.Controls.Add(this.buttonAddIncludeStatementToList);
            this.Controls.Add(this.buttonApplyFilter);
            this.Controls.Add(this.listBoxStatementsToInclude);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditOptionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generic Log Parser";
            this.Load += new System.EventHandler(this.EditOptionsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonApplyFilter;
        private System.Windows.Forms.Button buttonAddIncludeStatementToList;
        private System.Windows.Forms.Button buttonClearIncludeList;
        private System.Windows.Forms.RichTextBox richTextSampleInput;
        private System.Windows.Forms.ListBox listBoxStatementsToInclude;
        private System.Windows.Forms.TextBox textBoxSearchIncludeText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxHeaderRowSearchExpression;
        private System.Windows.Forms.Button buttonChooseHeader;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonClearExcludeList;
        private System.Windows.Forms.ListBox listBoxStatementsToExclude;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxSearchExcludeText;
        private System.Windows.Forms.Button buttonAddExcludeStatementToList;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxInputFormat;
        private System.Windows.Forms.TextBox textBoxOutputFormat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonSaveOptions;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxOutputFileSuffix;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox richTextSampleOutput;
    }
}
