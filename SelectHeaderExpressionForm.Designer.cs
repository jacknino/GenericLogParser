namespace GenericLogParser
{
    partial class SelectHeaderExpressionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectHeaderExpressionForm));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxName = new System.Windows.Forms.ComboBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonRemoveHeader = new System.Windows.Forms.Button();
            this.imageListButtonIcons = new System.Windows.Forms.ImageList(this.components);
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.bindingSourceSavedExpressions = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSavedExpressions)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // comboBoxName
            // 
            this.comboBoxName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxName.FormattingEnabled = true;
            this.comboBoxName.Location = new System.Drawing.Point(56, 6);
            this.comboBoxName.Name = "comboBoxName";
            this.comboBoxName.Size = new System.Drawing.Size(506, 21);
            this.comboBoxName.Sorted = true;
            this.comboBoxName.TabIndex = 0;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(517, 33);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 4;
            this.buttonOK.Text = "&OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(598, 33);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "&Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonRemoveHeader
            // 
            this.buttonRemoveHeader.ImageKey = "x16px.ico";
            this.buttonRemoveHeader.ImageList = this.imageListButtonIcons;
            this.buttonRemoveHeader.Location = new System.Drawing.Point(642, 4);
            this.buttonRemoveHeader.Name = "buttonRemoveHeader";
            this.buttonRemoveHeader.Size = new System.Drawing.Size(31, 23);
            this.buttonRemoveHeader.TabIndex = 3;
            this.buttonRemoveHeader.UseVisualStyleBackColor = true;
            this.buttonRemoveHeader.Click += new System.EventHandler(this.buttonRemoveHeader_Click);
            // 
            // imageListButtonIcons
            // 
            this.imageListButtonIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListButtonIcons.ImageStream")));
            this.imageListButtonIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListButtonIcons.Images.SetKeyName(0, "Loop16px.ico");
            this.imageListButtonIcons.Images.SetKeyName(1, "Plus16px.ico");
            this.imageListButtonIcons.Images.SetKeyName(2, "x16px.ico");
            // 
            // buttonEdit
            // 
            this.buttonEdit.ImageKey = "Loop16px.ico";
            this.buttonEdit.ImageList = this.imageListButtonIcons;
            this.buttonEdit.Location = new System.Drawing.Point(568, 4);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(31, 23);
            this.buttonEdit.TabIndex = 1;
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.ImageKey = "Plus16px.ico";
            this.buttonAdd.ImageList = this.imageListButtonIcons;
            this.buttonAdd.Location = new System.Drawing.Point(605, 4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(31, 23);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // SelectHeaderExpressionForm
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(680, 61);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonRemoveHeader);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.comboBoxName);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectHeaderExpressionForm";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Select Header Expression";
            this.Load += new System.EventHandler(this.SelectHeaderExpressionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSavedExpressions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxName;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonRemoveHeader;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.ImageList imageListButtonIcons;
        private System.Windows.Forms.BindingSource bindingSourceSavedExpressions;
    }
}