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
    // TODO:
    // If Include or Exclude text box gets focus make its associated Add To List the default button
    // otherwise Save or Apply
    // Make OutputFormat a multiline thing
    // Make Output show different steps
    // Multi-color syntax highlighting?
    // Read-only sample output?
    public partial class EditOptionsForm : Form
    {
        private LogParser _logParser = new LogParser();

        public EditOptionsForm()
        {
            // Required for Windows Form Designer support
            InitializeComponent();
        }

        private void EditOptionsForm_Load(object sender, EventArgs e)
        {
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

        private void buttonApplyFilter_Click(object sender, System.EventArgs e)
        {
            //if (!_logParser.IsProcessing)
            //{
            //    StartProcessing();
            //}
            //else
            //{
            //    StopProcessing();
            //}
        }

        private void StartProcessing()
        {
            if (CheckInputs() == false)
                return;

            List<string> inputFileArray = new List<string>();
            List<string> searchIncludeArray = GetArrayFromListBoxItems(listBoxStatementsToInclude);
            List<string> searchExcludeArray = GetArrayFromListBoxItems(listBoxStatementsToExclude);

            //richTextSampleInput.Clear();
            buttonApplyFilter.Text = "&Stop Filtering";

            // TODO:  Fix this
            string headerRowSearchExpression = textBoxHeaderRowSearchExpression.Text;

            _logParser.StartProcessing(
                inputFileArray,
                "",
                headerRowSearchExpression,
                searchIncludeArray,
                searchExcludeArray,
                textBoxInputFormat.Text,
                textBoxOutputFormat.Text);
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
            //bool includeItemsEntered = CheckTextBoxOrListBoxItem(listBoxStatementsToInclude, textBoxSearchIncludeText);
            //bool excludeItemsEntered = CheckTextBoxOrListBoxItem(listBoxStatementsToExclude, textBoxSearchExcludeText);

            //if (!includeItemsEntered && !excludeItemsEntered)
            //{
            //    MessageBox.Show("You must define at least one thing to parse for (at least one include statement or one exclude statement).", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return false;
            //}

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

        //private void AddToStatus(string statusText)
        //{
        //    if (richTextStatus.InvokeRequired)
        //    {
        //        AddToStatusCallback callback = AddToStatus;
        //        richTextStatus.Parent.Invoke(callback, new object[] { statusText });
        //    }
        //    else
        //    {
        //        richTextStatus.AppendText(statusText + "\r\n");
        //    }
        //}

        //private void EditOptionsForm_FormClosed(object sender, FormClosedEventArgs e)
        //{
        //    Properties.Settings.Default.Save();
        //}

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
