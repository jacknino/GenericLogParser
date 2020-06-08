using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Xml.Serialization;
using GenericLogParser.FilterExtensions;

namespace GenericLogParser
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public partial class MainForm : Form
    {
        private LogParser _logParser = new LogParser();

        private delegate void AddToStatusCallback(string statusText);
        private delegate void SetBytesProcessedCallback(
            long fileBytesProcessed,
            int fileRecordsFound,
            long totalBytesProcessed,
            int totalRecordsFound);

        public MainForm()
        {
            // Required for Windows Form Designer support
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CommandLineParser.Instance.ParseCommandLine(Environment.GetCommandLineArgs());

            _logParser.OnBytesProcessed += OnBytesProcessed;
            _logParser.OnProcessingComplete += OnProcessingComplete;
            _logParser.OnReportStatus += OnReportStatus;

            // Sample data
            //string headerFormat = @"^(?<Date>(\d{4})-(\d{2})-(\d{2})) (?<Time>(\d\d):(\d\d):(\d\d).(\d{3})) \((?<TickCount>(\d+))\) - (?<LogType>\w+)->(?<DebugGroup>\w+) \(Thread (?<ThreadName>.+) \((?<ThreadNumber>\d+)\)\) - Line: (?<LineNumber>\d+) - File: (?<FileName>[^\r\n]+)([\r\n]+)(?<RestOfIt>.*)";
            //string replaceFormat = "${Date} ${Time} <${ThreadName}> ${LogType} <${FileName}> [[${RestOfIt}]]";
            //string testString =
            //    "2015-09-25 16:19:38.062 (47) - DEBUG->PipConfigWrapper (Thread UNKNOWN NAME (1812)) - Line: 64 - File: PipConfigWrapper.cpp\r\n" +
            //    "Processing config file change for PIP.xml\r\n";
            //string replaced = Regex.Replace(testString, headerFormat, replaceFormat, RegexOptions.Singleline);
            //Debug.WriteLine(replaced);
        }

        private void OnBytesProcessed(
            long fileBytesProcessed,
            int fileRecordsFound,
            long totalBytesProcessed,
            int totalRecordsFound)
        {
            if (progressBarBytesProcessed.InvokeRequired)
            {
                SetBytesProcessedCallback callback = OnBytesProcessed;
                progressBarBytesProcessed.Parent.Invoke(callback, new object[] { fileBytesProcessed, fileRecordsFound, totalBytesProcessed, totalRecordsFound });
            }
            else
            {
                if (totalBytesProcessed == -1)
                {
                    // Complete.  Yes, I know it's cheesy to set the button text here and show a MessageBox
                    // I'm trying to make this thing do something useful right now.
                    progressBarBytesProcessed.Value = progressBarBytesProcessed.Maximum;
                    buttonApplyFilter.Text = "&Apply Filtering";
                    MessageBox.Show("Output complete.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    progressBarBytesProcessed.Value = (int)(totalBytesProcessed / 1000000);
                    AddToStatus(fileBytesProcessed + " (Total " + totalBytesProcessed
                        + ") bytes processed, " + fileRecordsFound
                        + " (Total " + totalRecordsFound + ") records found.");
                }
            }
        }

        private void OnProcessingComplete()
        {
            OnBytesProcessed(-1, -1, -1, -1);
        }

        private void OnReportStatus(string statusText)
        {
            AddToStatus(statusText);
        }

        private void buttonSelectInputFile_Click(object sender, EventArgs e)
        {
            string[] fileArray = SelectFiles(textBoxInputFile.Text, "", true);

            if (fileArray != null)
            {
                listBoxInputFiles.Items.Clear();
                textBoxOutputFile.Text = GenerateOutputFileName(fileArray[0]);

                foreach (string strFile in fileArray)
                {
                    listBoxInputFiles.Items.Add(strFile);
                }
            }
        }

        private void textBoxOutputFileSuffix_TextChanged(object sender, EventArgs e)
        {
            string inputFileName = listBoxInputFiles.Items.Count > 0 ? (string)listBoxInputFiles.Items[0] : "";
            textBoxOutputFile.Text = GenerateOutputFileName(inputFileName);
        }

        private string GenerateOutputFileName(string inputFile)
        {
            const string standardSuffix = "Parsed";
            string userSpecifiedSuffix = textBoxOutputFileSuffix.Text;

            int extensionLocation = inputFile.LastIndexOf('.');

            string outputFile;
            if (extensionLocation == -1)
            {
                outputFile = inputFile + standardSuffix + userSpecifiedSuffix;
            }
            else
            {
                outputFile = inputFile.Substring(0, extensionLocation)
                    + standardSuffix
                    + userSpecifiedSuffix
                    + inputFile.Substring(extensionLocation);
            }

            return outputFile;
        }

        private void buttonSelectOutputFile_Click(object sender, EventArgs e)
        {
            textBoxOutputFile.Text = SelectFile(textBoxOutputFile.Text, "", false);
        }

        private string SelectFile(string fileName, string filter, bool fileMustExist)
        {
            OpenFileDialog openFileDialog = SetupAndShowOpenFileDialog(fileName, filter, fileMustExist, false);
            return (openFileDialog != null ? openFileDialog.FileName : null);
        }

        private string[] SelectFiles(string fileName, string filter, bool fileMustExist)
        {
            OpenFileDialog openFileDialog = SetupAndShowOpenFileDialog(fileName, filter, fileMustExist, true);
            return (openFileDialog != null ? openFileDialog.FileNames : null);
        }

        private OpenFileDialog SetupAndShowOpenFileDialog(
            string fileName,
            string filter,
            bool fileMustExist,
            bool multiSelect)
        {
            if (filter == "")
                filter = "Log Files (*.log; *.txt)|*.log;*.txt|All Files (*.*)|*.*";

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.CheckFileExists = fileMustExist;
            openFileDialog.Filter = filter;
            openFileDialog.FileName = fileName;
            openFileDialog.Multiselect = multiSelect;

            if (openFileDialog.ShowDialog(this) != DialogResult.OK)
                return null;

            return openFileDialog;
        }

        private void buttonLoadOptions_Click(object sender, EventArgs e)
        {
            const string filter = "Parse Config Files (*.parseconfig)|*.parseconfig|All Files (*.*)|*.*";
            string inputFileName = SelectFile("", filter, true);
            if (string.IsNullOrEmpty(inputFileName))
                return;

            XmlSerializer serializer = new XmlSerializer(typeof(SaveOptionsData));
            SaveOptionsData saveOptionsData;
            using (TextReader textReader = new StreamReader(inputFileName))
            {
                saveOptionsData = (SaveOptionsData)serializer.Deserialize(textReader);
            }

            SetValuesFromSaveOptionsData(saveOptionsData);
        }

        private void SetValuesFromSaveOptionsData(SaveOptionsData saveOptionsData)
        {
            if (saveOptionsData.HeaderExpression != null)
            {
                textBoxHeaderRowSearchExpression.Text = saveOptionsData.HeaderExpression;
            }

            if (saveOptionsData.IncludeStatements != null)
            {
                listBoxStatementsToInclude.Items.Clear();
                saveOptionsData.IncludeStatements.ForEach(includeStatement => listBoxStatementsToInclude.Items.Add(includeStatement));
            }

            if (saveOptionsData.ExcludeStatements != null)
            {
                listBoxStatementsToExclude.Items.Clear();
                saveOptionsData.ExcludeStatements.ForEach(excludeStatement => listBoxStatementsToExclude.Items.Add(excludeStatement));
            }

            if (saveOptionsData.InputFormat != null)
                textBoxInputFormat.Text = saveOptionsData.InputFormat;

            if (saveOptionsData.OutputFormat != null)
                textBoxOutputFormat.Text = saveOptionsData.OutputFormat;
        }

        private string GetFilterExtensions()
        {
            //FilterExtensionsSection savedExpressions = FilterExtensionsSection.GetFilterExtensions();
            //foreach (FilterExtension filterExtension in savedExpressions)
            //{
            //    comboBoxName.Items.Add(savedExpression);
            //}

            return "";
        }

        private void buttonApplyFilter_Click(object sender, System.EventArgs e)
        {
            if (!_logParser.IsProcessing)
            {
                StartProcessing();
            }
            else
            {
                StopProcessing();
            }
        }

        private void StartProcessing()
        {
            if (CheckInputs() == false)
                return;

            List<string> inputFileArray = GetArrayFromListBoxItems(listBoxInputFiles);
            List<string> searchIncludeArray = GetArrayFromListBoxItems(listBoxStatementsToInclude);
            List<string> searchExcludeArray = GetArrayFromListBoxItems(listBoxStatementsToExclude);

            InitializeProgressBar(inputFileArray);
            richTextStatus.Clear();
            buttonApplyFilter.Text = "&Stop Filtering";

            // TODO:  Fix this
            string headerRowSearchExpression = textBoxHeaderRowSearchExpression.Text;

            _logParser.StartProcessing(
                inputFileArray,
                textBoxOutputFile.Text,
                headerRowSearchExpression,
                searchIncludeArray,
                searchExcludeArray,
                textBoxInputFormat.Text,
                textBoxOutputFormat.Text);
        }

        private void StopProcessing()
        {
            _logParser.StopProcessing();
            buttonApplyFilter.Text = "&Apply Filter";
        }

        private List<string> GetArrayFromListBoxItems(ListBox listBox)
        {
            List<string> array = new List<string>();
            foreach (string item in listBox.Items)
            {
                array.Add(item);
            }
            return array;
        }

        private bool CheckInputs()
        {
            if (!CheckTextBoxOrListBoxItem(listBoxInputFiles, textBoxInputFile))
            {
                MessageBox.Show("You must define at least one input file.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (textBoxOutputFile.Text.Trim() == "")
            {
                MessageBox.Show("You must define an output file.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            bool includeItemsEntered = CheckTextBoxOrListBoxItem(listBoxStatementsToInclude, textBoxSearchIncludeText);
            bool excludeItemsEntered = CheckTextBoxOrListBoxItem(listBoxStatementsToExclude, textBoxSearchExcludeText);

            if (!includeItemsEntered && !excludeItemsEntered)
            {
                MessageBox.Show("You must define at least one thing to parse for (at least one include statement or one exclude statement).", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

        private bool CheckTextBoxOrListBoxItem(ListBox listBox, TextBox textBox)
        {
            if (listBox.Items.Count == 0)
            {
                if (textBox.Text != "")
                {
                    listBox.Items.Add(textBox.Text);
                }
                else
                {
                    return false;
                }
            }

            return true;
        }

        private void InitializeProgressBar(List<string> fileNames)
        {
            long totalBytes = 0;

            foreach (string fileName in fileNames)
            {
                FileInfo fileInfo = new FileInfo(fileName);
                totalBytes += fileInfo.Length;
            }

            int totalMegabytes = (int)(totalBytes / 1000000);
            progressBarBytesProcessed.Maximum = totalMegabytes;
            progressBarBytesProcessed.Value = 0;
            labelMaxBytes.Text = totalMegabytes + " Megabytes";
        }

        private void buttonAddIncludeStatementToList_Click(object sender, System.EventArgs e)
        {
            listBoxStatementsToInclude.Items.Add(textBoxSearchIncludeText.Text);
        }

        private void buttonAddExcludeStatementToList_Click(object sender, EventArgs e)
        {
            listBoxStatementsToExclude.Items.Add(textBoxSearchExcludeText.Text);
        }

        private void buttonClearIncludeList_Click(object sender, System.EventArgs e)
        {
            listBoxStatementsToInclude.Items.Clear();
        }

        private void buttonClearExcludeList_Click(object sender, EventArgs e)
        {
            listBoxStatementsToExclude.Items.Clear();
        }

        private void AddToStatus(string statusText)
        {
            if (richTextStatus.InvokeRequired)
            {
                AddToStatusCallback callback = AddToStatus;
                richTextStatus.Parent.Invoke(callback, new object[] { statusText });
            }
            else
            {
                richTextStatus.AppendText(statusText + "\r\n");
            }
        }

        private void buttonEditOutput_Click(object sender, System.EventArgs e)
        {
            string outputFile = textBoxOutputFile.Text;

            if (File.Exists(outputFile))
            {
                Process.Start("Notepad.exe", outputFile);
            }
            else
            {
                MessageBox.Show(
                    outputFile + " does not exist.",
                    ProductName,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }

        private void listBoxInputFiles_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                listBoxInputFiles.Items.Remove(listBoxInputFiles.SelectedItem);
            }
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            labelBytesProcessed.Left = (Width - labelBytesProcessed.Width) / 2;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        private void buttonChooseHeader_Click(object sender, EventArgs e)
        {
            string headerExpression;
            if (SelectHeaderExpressionForm.Show(out headerExpression) == DialogResult.OK)
                textBoxHeaderRowSearchExpression.Text = headerExpression;
        }

        private void listBoxSearches_KeyUp(object sender, KeyEventArgs e)
        {
            if (sender.GetType() != typeof(ListBox))
                return;

            ListBox listBox = (ListBox)sender;
            if (e.KeyCode == Keys.Delete && listBox.SelectedItems.Count > 0)
            {
                while (listBox.SelectedItems.Count > 0)
                    listBox.Items.Remove(listBox.SelectedItems[0]);
            }
        }

        private void buttonSaveOptions_Click(object sender, EventArgs e)
        {
            string description = "";
            string comment = "";
            string exampleInput = "";

            SaveOptionsData saveOptionsData = new SaveOptionsData(
                textBoxHeaderRowSearchExpression.Text,
                GetArrayFromListBoxItems(listBoxStatementsToInclude),
                GetArrayFromListBoxItems(listBoxStatementsToExclude),
                textBoxInputFormat.Text,
                textBoxOutputFormat.Text,
                textBoxOutputFileSuffix.Text,
                description,
                comment,
                exampleInput);

            SaveOptionsForm.Show(saveOptionsData);
        }
    }
}
