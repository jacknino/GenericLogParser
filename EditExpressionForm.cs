using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using GenericLogParser.SavedExpressions;

namespace GenericLogParser
{
    public partial class EditExpressionForm : Form
    {
        private readonly Color _defaultRichTextBoxBackColor;

        private SavedExpression SavedExpression { get; set; }

        public static DialogResult Show(SavedExpression originalSavedExpression, out SavedExpression newSavedExpression)
        {
            EditExpressionForm editExpressionForm = new EditExpressionForm(originalSavedExpression);
            DialogResult dialogResult = editExpressionForm.ShowDialog();
            newSavedExpression = editExpressionForm.SavedExpression;
            return dialogResult;
        }

        public static DialogResult Show(out SavedExpression savedExpression)
        {
            return Show(null, out savedExpression);
        }

        public EditExpressionForm(SavedExpression savedExpression)
        {
            InitializeComponent();

            _defaultRichTextBoxBackColor = richTextBoxTestData.BackColor;

            if (savedExpression != null)
            {
                textBoxName.Text = savedExpression.Name;
                textBoxExpression.Text = savedExpression.HeaderExpression;
            }
        }

        private void textBoxExpression_TextChanged(object sender, EventArgs e)
        {
            HighlightMatch();
        }

        private void richTextBoxTestData_TextChanged(object sender, EventArgs e)
        {
            HighlightMatch();
        }

        private void HighlightMatch()
        {
            string searchExpression = textBoxExpression.Text;
            string data = richTextBoxTestData.Text;

            richTextBoxTestData.Select(0, richTextBoxTestData.TextLength);
            richTextBoxTestData.SelectionBackColor = _defaultRichTextBoxBackColor;

            try
            {
                Match match = Regex.Match(data, searchExpression);
                while (match.Success)
                {
                    richTextBoxTestData.Select(match.Index, match.Length);
                    richTextBoxTestData.SelectionBackColor = Color.Green;
                    match = match.NextMatch();
                }
            }
            catch (ArgumentException)
            {
                // If the searchExpression isn't correct yet we can just ignore the problem
            }

            richTextBoxTestData.DeselectAll();

            // Other option
            //   Read Line
            //   Search Regex
            //   If found, extract matching string
            //   Find next line
            //using (StringReader stringReader = new StringReader(data))
            //{
            //    string line;
            //    while ((line = stringReader.ReadLine()) != null)
            //    {
            //        try
            //        {
            //            Match match = Regex.Match(line, searchExpression);
            //            if (match.Success)
            //            {
            //                richTextBoxTestData.Select(match.Index, match.Length);
            //                richTextBoxTestData.SelectionBackColor = Color.Green;
            //            }
            //            else
            //            {
            //                richTextBoxTestData.SelectionLength = 0;
            //            }
            //        }
            //        catch (ArgumentException)
            //        {
            //            // If the expression isn't correct yet we can just ignore the problem
            //        }
            //    }
            //}
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (!DataIsValid())
            {
                return;
            }

            SavedExpression savedExpression = new SavedExpression();
            savedExpression.Name = textBoxName.Text;
            savedExpression.HeaderExpression = textBoxExpression.Text;
            SavedExpression = savedExpression;
            DialogResult = DialogResult.OK;
        }

        private bool DataIsValid()
        {
            if (!CheckTextBox("Name", textBoxName))
                return false;

            if (!CheckTextBox("Expression", textBoxExpression))
                return false;

            return true;
        }

        private bool CheckTextBox(string name, TextBox textBox)
        {
            if (string.IsNullOrEmpty(textBox.Text))
            {
                MessageBox.Show(string.Format("{0} must be specified", name), "Edit Expression", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox.Focus();
                return false;
            }

            return true;
        }

        private void richTextBoxTestData_SelectionChanged(object sender, EventArgs e)
        {
            int index = richTextBoxTestData.SelectionStart;
            int length = richTextBoxTestData.SelectionLength;
        }
    }
}
