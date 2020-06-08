using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace GenericLogParser
{
    public partial class SaveOptionsForm : Form
    {
        private readonly SaveOptionsData _saveOptionsData;

        public static DialogResult Show(SaveOptionsData saveOptionsData)
        {
            SaveOptionsForm saveOptionsForm = new SaveOptionsForm(saveOptionsData);
            DialogResult dialogResult = saveOptionsForm.ShowDialog();
            return dialogResult;
        }

        public SaveOptionsForm(SaveOptionsData saveOptionsData)
        {
            _saveOptionsData = saveOptionsData;

            InitializeComponent();
        }

        private void buttonSelectOutputFile_Click(object sender, EventArgs e)
        {
            textBoxOutputFile.Text = SelectFile(textBoxOutputFile.Text);
        }

        private string SelectFile(string fileName)
        {
            OpenFileDialog openFileDialog = SetupAndShowOpenFileDialog(fileName);
            return (openFileDialog != null ? openFileDialog.FileName : null);
        }

        private OpenFileDialog SetupAndShowOpenFileDialog(string fileName)
        {
            string filter = "Parse Config Files (*.parseconfig)|*.parseconfig|All Files (*.*)|*.*";

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.CheckFileExists = false;
            openFileDialog.Filter = filter;
            openFileDialog.FileName = fileName;
            openFileDialog.Multiselect = false;
            openFileDialog.DefaultExt = "parseconfig";

            if (openFileDialog.ShowDialog(this) != DialogResult.OK)
                return null;

            return openFileDialog;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (!checkBoxSaveHeaderExpression.Checked)
                    _saveOptionsData.HeaderExpression = null;

                if (!checkBoxSaveIncludeStatements.Checked)
                    _saveOptionsData.IncludeStatements = null;

                if (!checkBoxSaveExcludeStatements.Checked)
                    _saveOptionsData.ExcludeStatements = null;

                if (!checkBoxSaveInputFormat.Checked)
                    _saveOptionsData.InputFormat = null;

                if (!checkBoxSaveOutputFormat.Checked)
                    _saveOptionsData.OutputFormat = null;

                XmlSerializer serializer = new XmlSerializer(typeof(SaveOptionsData));

                TextWriter textWriter = new StreamWriter(textBoxOutputFile.Text);
                serializer.Serialize(textWriter, _saveOptionsData);
                textWriter.Close();

                MessageBox.Show("Options save to " + textBoxOutputFile.Text, "Save Options", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed trying to save options to " + textBoxOutputFile.Text + "\r\n\r\n" + ex, "Save Options", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
