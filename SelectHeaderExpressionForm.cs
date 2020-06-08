using System;
using System.Windows.Forms;
using GenericLogParser.SavedExpressions;

namespace GenericLogParser
{
    public partial class SelectHeaderExpressionForm : Form
    {
        private string HeaderExpression { get; set; }

        private SavedExpressionCollection _savedExpressionCollection;

        public static DialogResult Show(out string headerExpression)
        {
            SelectHeaderExpressionForm selectHeaderExpressionForm = new SelectHeaderExpressionForm();
            DialogResult dialogResult = selectHeaderExpressionForm.ShowDialog();
            headerExpression = selectHeaderExpressionForm.HeaderExpression;
            return dialogResult;
        }

        private SelectHeaderExpressionForm()
        {
            _savedExpressionCollection = SavedExpressionsSection.GetSavedExpressions();
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (comboBoxName.SelectedItem != null)
                HeaderExpression = ((SavedExpression)comboBoxName.SelectedItem).HeaderExpression;

            DialogResult = DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void SelectHeaderExpressionForm_Load(object sender, EventArgs e)
        {
            LoadExpressions();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            SavedExpression savedExpression;
            if (DialogResult.OK == EditExpressionForm.Show(out savedExpression))
            {
                _savedExpressionCollection = SavedExpressionsSection.Add(savedExpression);
                LoadExpressions();
                comboBoxName.SelectedItem = savedExpression;
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (comboBoxName.SelectedItem != null)
            {
                SavedExpression originalSavedExpression = (SavedExpression)comboBoxName.SelectedItem;
                SavedExpression newSavedExpression;
                if (DialogResult.OK == EditExpressionForm.Show(originalSavedExpression, out newSavedExpression))
                {
                    _savedExpressionCollection = SavedExpressionsSection.Remove(originalSavedExpression.Name);
                    _savedExpressionCollection = SavedExpressionsSection.Add(newSavedExpression);
                    LoadExpressions();
                    comboBoxName.SelectedItem = newSavedExpression;
                }
            }
        }

        private void buttonRemoveHeader_Click(object sender, EventArgs e)
        {
            if (comboBoxName.SelectedItem != null)
            {
                SavedExpression savedExpression = (SavedExpression)comboBoxName.SelectedItem;
                if (DialogResult.Yes == MessageBox.Show("Are you sure you want to remove the " + savedExpression.Name + " expression?", "Select Header Expression", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    _savedExpressionCollection = SavedExpressionsSection.Remove(savedExpression.Name);
                    LoadExpressions();
                }
            }
        }

        private void LoadExpressions()
        {
            comboBoxName.Items.Clear();
            foreach (SavedExpression savedExpression in _savedExpressionCollection)
            {
                comboBoxName.Items.Add(savedExpression);
            }

            if (comboBoxName.Items.Count > 0)
                comboBoxName.SelectedItem = comboBoxName.Items[0];
        }
    }
}
