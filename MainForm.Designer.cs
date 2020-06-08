namespace GenericLogParser
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.buttonSelectInputFile = new System.Windows.Forms.Button();
            this.textBoxInputFile = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxStatementsToInclude = new System.Windows.Forms.ListBox();
            this.buttonApplyFilter = new System.Windows.Forms.Button();
            this.buttonAddIncludeStatementToList = new System.Windows.Forms.Button();
            this.buttonClearIncludeList = new System.Windows.Forms.Button();
            this.buttonSelectOutputFile = new System.Windows.Forms.Button();
            this.textBoxOutputFile = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.progressBarBytesProcessed = new System.Windows.Forms.ProgressBar();
            this.labelMaxBytes = new System.Windows.Forms.Label();
            this.labelMinBytes = new System.Windows.Forms.Label();
            this.labelBytesProcessed = new System.Windows.Forms.Label();
            this.richTextStatus = new System.Windows.Forms.RichTextBox();
            this.buttonEditOutput = new System.Windows.Forms.Button();
            this.textBoxSearchIncludeText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxInputFiles = new System.Windows.Forms.ListBox();
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
            this.buttonLoadOptions = new System.Windows.Forms.Button();
            this.textBoxHeaderRowSearchExpression = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxOutputFileSuffix = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonSelectInputFile
            // 
            this.buttonSelectInputFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSelectInputFile.Location = new System.Drawing.Point(720, 8);
            this.buttonSelectInputFile.Name = "buttonSelectInputFile";
            this.buttonSelectInputFile.Size = new System.Drawing.Size(24, 20);
            this.buttonSelectInputFile.TabIndex = 1;
            this.buttonSelectInputFile.Text = "&...";
            this.buttonSelectInputFile.Click += new System.EventHandler(this.buttonSelectInputFile_Click);
            // 
            // textBoxInputFile
            // 
            this.textBoxInputFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxInputFile.Location = new System.Drawing.Point(64, 8);
            this.textBoxInputFile.Name = "textBoxInputFile";
            this.textBoxInputFile.Size = new System.Drawing.Size(652, 20);
            this.textBoxInputFile.TabIndex = 0;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(8, 12);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(50, 13);
            this.Label1.TabIndex = 3;
            this.Label1.Text = "Input File";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 215);
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
            this.listBoxStatementsToInclude.Location = new System.Drawing.Point(8, 232);
            this.listBoxStatementsToInclude.Name = "listBoxStatementsToInclude";
            this.listBoxStatementsToInclude.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxStatementsToInclude.Size = new System.Drawing.Size(616, 95);
            this.listBoxStatementsToInclude.TabIndex = 10;
            this.listBoxStatementsToInclude.KeyUp += new System.Windows.Forms.KeyEventHandler(this.listBoxSearches_KeyUp);
            // 
            // buttonApplyFilter
            // 
            this.buttonApplyFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonApplyFilter.Location = new System.Drawing.Point(636, 496);
            this.buttonApplyFilter.Name = "buttonApplyFilter";
            this.buttonApplyFilter.Size = new System.Drawing.Size(108, 24);
            this.buttonApplyFilter.TabIndex = 21;
            this.buttonApplyFilter.Text = "Apply &Filter";
            this.buttonApplyFilter.Click += new System.EventHandler(this.buttonApplyFilter_Click);
            // 
            // buttonAddIncludeStatementToList
            // 
            this.buttonAddIncludeStatementToList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddIncludeStatementToList.Location = new System.Drawing.Point(636, 189);
            this.buttonAddIncludeStatementToList.Name = "buttonAddIncludeStatementToList";
            this.buttonAddIncludeStatementToList.Size = new System.Drawing.Size(108, 24);
            this.buttonAddIncludeStatementToList.TabIndex = 9;
            this.buttonAddIncludeStatementToList.Text = "&Add To List";
            this.buttonAddIncludeStatementToList.Click += new System.EventHandler(this.buttonAddIncludeStatementToList_Click);
            // 
            // buttonClearIncludeList
            // 
            this.buttonClearIncludeList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClearIncludeList.Location = new System.Drawing.Point(636, 232);
            this.buttonClearIncludeList.Name = "buttonClearIncludeList";
            this.buttonClearIncludeList.Size = new System.Drawing.Size(108, 24);
            this.buttonClearIncludeList.TabIndex = 11;
            this.buttonClearIncludeList.Text = "&Clear List";
            this.buttonClearIncludeList.Click += new System.EventHandler(this.buttonClearIncludeList_Click);
            // 
            // buttonSelectOutputFile
            // 
            this.buttonSelectOutputFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSelectOutputFile.Location = new System.Drawing.Point(720, 135);
            this.buttonSelectOutputFile.Name = "buttonSelectOutputFile";
            this.buttonSelectOutputFile.Size = new System.Drawing.Size(24, 20);
            this.buttonSelectOutputFile.TabIndex = 5;
            this.buttonSelectOutputFile.Text = "&...";
            this.buttonSelectOutputFile.Click += new System.EventHandler(this.buttonSelectOutputFile_Click);
            // 
            // textBoxOutputFile
            // 
            this.textBoxOutputFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOutputFile.Location = new System.Drawing.Point(64, 135);
            this.textBoxOutputFile.Name = "textBoxOutputFile";
            this.textBoxOutputFile.Size = new System.Drawing.Size(652, 20);
            this.textBoxOutputFile.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Output File";
            // 
            // progressBarBytesProcessed
            // 
            this.progressBarBytesProcessed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarBytesProcessed.Location = new System.Drawing.Point(8, 727);
            this.progressBarBytesProcessed.Name = "progressBarBytesProcessed";
            this.progressBarBytesProcessed.Size = new System.Drawing.Size(736, 16);
            this.progressBarBytesProcessed.TabIndex = 14;
            // 
            // labelMaxBytes
            // 
            this.labelMaxBytes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMaxBytes.Location = new System.Drawing.Point(611, 710);
            this.labelMaxBytes.Name = "labelMaxBytes";
            this.labelMaxBytes.Size = new System.Drawing.Size(129, 16);
            this.labelMaxBytes.TabIndex = 27;
            this.labelMaxBytes.Text = "0 Megabytes";
            this.labelMaxBytes.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelMinBytes
            // 
            this.labelMinBytes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelMinBytes.AutoSize = true;
            this.labelMinBytes.Location = new System.Drawing.Point(8, 710);
            this.labelMinBytes.Name = "labelMinBytes";
            this.labelMinBytes.Size = new System.Drawing.Size(13, 13);
            this.labelMinBytes.TabIndex = 28;
            this.labelMinBytes.Text = "0";
            // 
            // labelBytesProcessed
            // 
            this.labelBytesProcessed.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelBytesProcessed.AutoSize = true;
            this.labelBytesProcessed.Location = new System.Drawing.Point(334, 710);
            this.labelBytesProcessed.Name = "labelBytesProcessed";
            this.labelBytesProcessed.Size = new System.Drawing.Size(86, 13);
            this.labelBytesProcessed.TabIndex = 29;
            this.labelBytesProcessed.Text = "Bytes Processed";
            // 
            // richTextStatus
            // 
            this.richTextStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextStatus.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextStatus.Location = new System.Drawing.Point(8, 524);
            this.richTextStatus.Name = "richTextStatus";
            this.richTextStatus.Size = new System.Drawing.Size(736, 179);
            this.richTextStatus.TabIndex = 22;
            this.richTextStatus.Text = "";
            this.richTextStatus.WordWrap = false;
            // 
            // buttonEditOutput
            // 
            this.buttonEditOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEditOutput.Location = new System.Drawing.Point(636, 470);
            this.buttonEditOutput.Name = "buttonEditOutput";
            this.buttonEditOutput.Size = new System.Drawing.Size(108, 24);
            this.buttonEditOutput.TabIndex = 19;
            this.buttonEditOutput.Text = "&Edit Output";
            this.buttonEditOutput.Click += new System.EventHandler(this.buttonEditOutput_Click);
            // 
            // textBoxSearchIncludeText
            // 
            this.textBoxSearchIncludeText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearchIncludeText.Location = new System.Drawing.Point(64, 192);
            this.textBoxSearchIncludeText.Name = "textBoxSearchIncludeText";
            this.textBoxSearchIncludeText.Size = new System.Drawing.Size(560, 20);
            this.textBoxSearchIncludeText.TabIndex = 8;
            this.textBoxSearchIncludeText.Enter += new System.EventHandler(this.textBoxSearchIncludeText_Enter);
            this.textBoxSearchIncludeText.Leave += new System.EventHandler(this.textBoxSearchIncludeText_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Include";
            // 
            // listBoxInputFiles
            // 
            this.listBoxInputFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxInputFiles.HorizontalScrollbar = true;
            this.listBoxInputFiles.Location = new System.Drawing.Point(64, 32);
            this.listBoxInputFiles.Name = "listBoxInputFiles";
            this.listBoxInputFiles.Size = new System.Drawing.Size(652, 69);
            this.listBoxInputFiles.Sorted = true;
            this.listBoxInputFiles.TabIndex = 2;
            this.listBoxInputFiles.KeyUp += new System.Windows.Forms.KeyEventHandler(this.listBoxInputFiles_KeyUp);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(8, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 32);
            this.label4.TabIndex = 35;
            this.label4.Text = "Header Expression";
            // 
            // buttonChooseHeader
            // 
            this.buttonChooseHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonChooseHeader.Location = new System.Drawing.Point(636, 161);
            this.buttonChooseHeader.Name = "buttonChooseHeader";
            this.buttonChooseHeader.Size = new System.Drawing.Size(108, 24);
            this.buttonChooseHeader.TabIndex = 7;
            this.buttonChooseHeader.Text = "Choose &Header...";
            this.buttonChooseHeader.Click += new System.EventHandler(this.buttonChooseHeader_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 357);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Statements To Exclude";
            // 
            // buttonClearExcludeList
            // 
            this.buttonClearExcludeList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClearExcludeList.Location = new System.Drawing.Point(636, 374);
            this.buttonClearExcludeList.Name = "buttonClearExcludeList";
            this.buttonClearExcludeList.Size = new System.Drawing.Size(108, 24);
            this.buttonClearExcludeList.TabIndex = 15;
            this.buttonClearExcludeList.Text = "Clea&r List";
            this.buttonClearExcludeList.Click += new System.EventHandler(this.buttonClearExcludeList_Click);
            // 
            // listBoxStatementsToExclude
            // 
            this.listBoxStatementsToExclude.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxStatementsToExclude.HorizontalScrollbar = true;
            this.listBoxStatementsToExclude.Location = new System.Drawing.Point(8, 374);
            this.listBoxStatementsToExclude.Name = "listBoxStatementsToExclude";
            this.listBoxStatementsToExclude.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxStatementsToExclude.Size = new System.Drawing.Size(616, 95);
            this.listBoxStatementsToExclude.TabIndex = 14;
            this.listBoxStatementsToExclude.KeyUp += new System.Windows.Forms.KeyEventHandler(this.listBoxSearches_KeyUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 337);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "Exclude";
            // 
            // textBoxSearchExcludeText
            // 
            this.textBoxSearchExcludeText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearchExcludeText.Location = new System.Drawing.Point(64, 334);
            this.textBoxSearchExcludeText.Name = "textBoxSearchExcludeText";
            this.textBoxSearchExcludeText.Size = new System.Drawing.Size(560, 20);
            this.textBoxSearchExcludeText.TabIndex = 12;
            this.textBoxSearchExcludeText.Enter += new System.EventHandler(this.textBoxSearchExcludeText_Enter);
            this.textBoxSearchExcludeText.Leave += new System.EventHandler(this.textBoxSearchExcludeText_Leave);
            // 
            // buttonAddExcludeStatementToList
            // 
            this.buttonAddExcludeStatementToList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddExcludeStatementToList.Location = new System.Drawing.Point(636, 331);
            this.buttonAddExcludeStatementToList.Name = "buttonAddExcludeStatementToList";
            this.buttonAddExcludeStatementToList.Size = new System.Drawing.Size(108, 24);
            this.buttonAddExcludeStatementToList.TabIndex = 13;
            this.buttonAddExcludeStatementToList.Text = "Add To &List";
            this.buttonAddExcludeStatementToList.Click += new System.EventHandler(this.buttonAddExcludeStatementToList_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 476);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 42;
            this.label7.Text = "Input Format";
            // 
            // textBoxInputFormat
            // 
            this.textBoxInputFormat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxInputFormat.Location = new System.Drawing.Point(88, 473);
            this.textBoxInputFormat.Name = "textBoxInputFormat";
            this.textBoxInputFormat.Size = new System.Drawing.Size(536, 20);
            this.textBoxInputFormat.TabIndex = 18;
            // 
            // textBoxOutputFormat
            // 
            this.textBoxOutputFormat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOutputFormat.Location = new System.Drawing.Point(88, 499);
            this.textBoxOutputFormat.Name = "textBoxOutputFormat";
            this.textBoxOutputFormat.Size = new System.Drawing.Size(536, 20);
            this.textBoxOutputFormat.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 502);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 44;
            this.label9.Text = "Output Format";
            // 
            // buttonSaveOptions
            // 
            this.buttonSaveOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveOptions.Location = new System.Drawing.Point(636, 420);
            this.buttonSaveOptions.Name = "buttonSaveOptions";
            this.buttonSaveOptions.Size = new System.Drawing.Size(108, 24);
            this.buttonSaveOptions.TabIndex = 16;
            this.buttonSaveOptions.Text = "&Save Options...";
            this.buttonSaveOptions.Click += new System.EventHandler(this.buttonSaveOptions_Click);
            // 
            // buttonLoadOptions
            // 
            this.buttonLoadOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLoadOptions.Location = new System.Drawing.Point(636, 445);
            this.buttonLoadOptions.Name = "buttonLoadOptions";
            this.buttonLoadOptions.Size = new System.Drawing.Size(108, 24);
            this.buttonLoadOptions.TabIndex = 17;
            this.buttonLoadOptions.Text = "Load &Options...";
            this.buttonLoadOptions.Click += new System.EventHandler(this.buttonLoadOptions_Click);
            // 
            // textBoxHeaderRowSearchExpression
            // 
            this.textBoxHeaderRowSearchExpression.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxHeaderRowSearchExpression.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::GenericLogParser.Properties.Settings.Default, "LastHeaderSearchExpression", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxHeaderRowSearchExpression.Location = new System.Drawing.Point(64, 164);
            this.textBoxHeaderRowSearchExpression.Name = "textBoxHeaderRowSearchExpression";
            this.textBoxHeaderRowSearchExpression.Size = new System.Drawing.Size(560, 20);
            this.textBoxHeaderRowSearchExpression.TabIndex = 6;
            this.textBoxHeaderRowSearchExpression.Text = global::GenericLogParser.Properties.Settings.Default.LastHeaderSearchExpression;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(8, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 32);
            this.label10.TabIndex = 48;
            this.label10.Text = "Output File Suffix";
            // 
            // textBoxOutputFileSuffix
            // 
            this.textBoxOutputFileSuffix.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOutputFileSuffix.Location = new System.Drawing.Point(64, 109);
            this.textBoxOutputFileSuffix.Name = "textBoxOutputFileSuffix";
            this.textBoxOutputFileSuffix.Size = new System.Drawing.Size(652, 20);
            this.textBoxOutputFileSuffix.TabIndex = 3;
            this.textBoxOutputFileSuffix.TextChanged += new System.EventHandler(this.textBoxOutputFileSuffix_TextChanged);
            // 
            // MainForm
            // 
            this.AcceptButton = this.buttonApplyFilter;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(756, 751);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxOutputFileSuffix);
            this.Controls.Add(this.buttonLoadOptions);
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
            this.Controls.Add(this.listBoxInputFiles);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxSearchIncludeText);
            this.Controls.Add(this.buttonEditOutput);
            this.Controls.Add(this.richTextStatus);
            this.Controls.Add(this.labelBytesProcessed);
            this.Controls.Add(this.labelMinBytes);
            this.Controls.Add(this.labelMaxBytes);
            this.Controls.Add(this.textBoxOutputFile);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxInputFile);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.progressBarBytesProcessed);
            this.Controls.Add(this.buttonSelectOutputFile);
            this.Controls.Add(this.buttonClearIncludeList);
            this.Controls.Add(this.buttonAddIncludeStatementToList);
            this.Controls.Add(this.buttonApplyFilter);
            this.Controls.Add(this.listBoxStatementsToInclude);
            this.Controls.Add(this.buttonSelectInputFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generic Log Parser";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonApplyFilter;
        private System.Windows.Forms.Button buttonAddIncludeStatementToList;
        private System.Windows.Forms.Button buttonClearIncludeList;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonSelectInputFile;
        private System.Windows.Forms.TextBox textBoxInputFile;
        private System.Windows.Forms.Button buttonSelectOutputFile;
        private System.Windows.Forms.TextBox textBoxOutputFile;

        private System.Windows.Forms.Label labelMaxBytes;
        private System.Windows.Forms.Label labelMinBytes;
        private System.Windows.Forms.Label labelBytesProcessed;
        private System.Windows.Forms.ProgressBar progressBarBytesProcessed;
        private System.Windows.Forms.RichTextBox richTextStatus;
        private System.Windows.Forms.Button buttonEditOutput;
        private System.Windows.Forms.ListBox listBoxStatementsToInclude;
        private System.Windows.Forms.TextBox textBoxSearchIncludeText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxInputFiles;
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
        private System.Windows.Forms.Button buttonLoadOptions;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxOutputFileSuffix;
    }
}
