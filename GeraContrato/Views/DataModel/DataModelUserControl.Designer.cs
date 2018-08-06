namespace GeraContrato.Views
{
    partial class DataModelUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DataModelPanel = new System.Windows.Forms.Panel();
            this.DataModelInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.DataModelNameLabel = new System.Windows.Forms.Label();
            this.DataModelNameTextBox = new System.Windows.Forms.TextBox();
            this.DataItemLabel = new System.Windows.Forms.Label();
            this.AddDataItemButton = new System.Windows.Forms.Button();
            this.RemoveNewDataItemButton = new System.Windows.Forms.Button();
            this.DataItemTextBox = new System.Windows.Forms.TextBox();
            this.NewDataItemsListBox = new System.Windows.Forms.ListBox();
            this.SaveDataModelButton = new System.Windows.Forms.Button();
            this.SelectDataModelPanel = new System.Windows.Forms.Panel();
            this.SelectDataModelLabel = new System.Windows.Forms.Label();
            this.ManageableDataModelsComboBox = new System.Windows.Forms.ComboBox();
            this.DeleteDataModelButton = new System.Windows.Forms.Button();
            this.ChooseDataModelGroupBox = new System.Windows.Forms.GroupBox();
            this.CreateDataModelRadioButton = new System.Windows.Forms.RadioButton();
            this.UpdateDataModelRadioButton = new System.Windows.Forms.RadioButton();
            this.DataModelPanel.SuspendLayout();
            this.DataModelInfoGroupBox.SuspendLayout();
            this.SelectDataModelPanel.SuspendLayout();
            this.ChooseDataModelGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataModelPanel
            // 
            this.DataModelPanel.Controls.Add(this.DataModelInfoGroupBox);
            this.DataModelPanel.Controls.Add(this.SelectDataModelPanel);
            this.DataModelPanel.Controls.Add(this.ChooseDataModelGroupBox);
            this.DataModelPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataModelPanel.Location = new System.Drawing.Point(0, 0);
            this.DataModelPanel.Name = "DataModelPanel";
            this.DataModelPanel.Size = new System.Drawing.Size(829, 533);
            this.DataModelPanel.TabIndex = 0;
            this.DataModelPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.DataModelPanel_Paint);
            // 
            // DataModelInfoGroupBox
            // 
            this.DataModelInfoGroupBox.Controls.Add(this.DataModelNameLabel);
            this.DataModelInfoGroupBox.Controls.Add(this.DataModelNameTextBox);
            this.DataModelInfoGroupBox.Controls.Add(this.DataItemLabel);
            this.DataModelInfoGroupBox.Controls.Add(this.AddDataItemButton);
            this.DataModelInfoGroupBox.Controls.Add(this.RemoveNewDataItemButton);
            this.DataModelInfoGroupBox.Controls.Add(this.DataItemTextBox);
            this.DataModelInfoGroupBox.Controls.Add(this.NewDataItemsListBox);
            this.DataModelInfoGroupBox.Controls.Add(this.SaveDataModelButton);
            this.DataModelInfoGroupBox.Location = new System.Drawing.Point(278, 138);
            this.DataModelInfoGroupBox.Name = "DataModelInfoGroupBox";
            this.DataModelInfoGroupBox.Size = new System.Drawing.Size(541, 297);
            this.DataModelInfoGroupBox.TabIndex = 7;
            this.DataModelInfoGroupBox.TabStop = false;
            this.DataModelInfoGroupBox.Text = "Modelo de Dados";
            // 
            // DataModelNameLabel
            // 
            this.DataModelNameLabel.AutoSize = true;
            this.DataModelNameLabel.Location = new System.Drawing.Point(167, 37);
            this.DataModelNameLabel.Name = "DataModelNameLabel";
            this.DataModelNameLabel.Size = new System.Drawing.Size(38, 13);
            this.DataModelNameLabel.TabIndex = 8;
            this.DataModelNameLabel.Text = "Nome:";
            // 
            // DataModelNameTextBox
            // 
            this.DataModelNameTextBox.Location = new System.Drawing.Point(211, 34);
            this.DataModelNameTextBox.Name = "DataModelNameTextBox";
            this.DataModelNameTextBox.Size = new System.Drawing.Size(176, 20);
            this.DataModelNameTextBox.TabIndex = 7;
            // 
            // DataItemLabel
            // 
            this.DataItemLabel.AutoSize = true;
            this.DataItemLabel.Location = new System.Drawing.Point(31, 78);
            this.DataItemLabel.Name = "DataItemLabel";
            this.DataItemLabel.Size = new System.Drawing.Size(118, 13);
            this.DataItemLabel.TabIndex = 4;
            this.DataItemLabel.Text = "Identificador do campo:";
            // 
            // AddDataItemButton
            // 
            this.AddDataItemButton.Location = new System.Drawing.Point(211, 120);
            this.AddDataItemButton.Name = "AddDataItemButton";
            this.AddDataItemButton.Size = new System.Drawing.Size(90, 39);
            this.AddDataItemButton.TabIndex = 2;
            this.AddDataItemButton.Text = "Adicionar campo";
            this.AddDataItemButton.UseVisualStyleBackColor = true;
            this.AddDataItemButton.Click += new System.EventHandler(this.AddDataItemButton_Click);
            // 
            // RemoveNewDataItemButton
            // 
            this.RemoveNewDataItemButton.Location = new System.Drawing.Point(214, 241);
            this.RemoveNewDataItemButton.Name = "RemoveNewDataItemButton";
            this.RemoveNewDataItemButton.Size = new System.Drawing.Size(90, 39);
            this.RemoveNewDataItemButton.TabIndex = 6;
            this.RemoveNewDataItemButton.Text = "Remover selecionado";
            this.RemoveNewDataItemButton.UseVisualStyleBackColor = true;
            this.RemoveNewDataItemButton.Click += new System.EventHandler(this.RemoveNewDataItemButton_Click);
            // 
            // DataItemTextBox
            // 
            this.DataItemTextBox.Location = new System.Drawing.Point(31, 94);
            this.DataItemTextBox.Name = "DataItemTextBox";
            this.DataItemTextBox.Size = new System.Drawing.Size(176, 20);
            this.DataItemTextBox.TabIndex = 3;
            // 
            // NewDataItemsListBox
            // 
            this.NewDataItemsListBox.FormattingEnabled = true;
            this.NewDataItemsListBox.Location = new System.Drawing.Point(31, 120);
            this.NewDataItemsListBox.Name = "NewDataItemsListBox";
            this.NewDataItemsListBox.Size = new System.Drawing.Size(174, 160);
            this.NewDataItemsListBox.TabIndex = 1;
            // 
            // SaveDataModelButton
            // 
            this.SaveDataModelButton.Location = new System.Drawing.Point(374, 226);
            this.SaveDataModelButton.Name = "SaveDataModelButton";
            this.SaveDataModelButton.Size = new System.Drawing.Size(161, 65);
            this.SaveDataModelButton.TabIndex = 5;
            this.SaveDataModelButton.Text = "Criar modelo de dados";
            this.SaveDataModelButton.UseVisualStyleBackColor = true;
            this.SaveDataModelButton.Click += new System.EventHandler(this.SaveDataModelButton_Click);
            // 
            // SelectDataModelPanel
            // 
            this.SelectDataModelPanel.Controls.Add(this.SelectDataModelLabel);
            this.SelectDataModelPanel.Controls.Add(this.ManageableDataModelsComboBox);
            this.SelectDataModelPanel.Controls.Add(this.DeleteDataModelButton);
            this.SelectDataModelPanel.Location = new System.Drawing.Point(18, 138);
            this.SelectDataModelPanel.Name = "SelectDataModelPanel";
            this.SelectDataModelPanel.Size = new System.Drawing.Size(254, 202);
            this.SelectDataModelPanel.TabIndex = 13;
            // 
            // SelectDataModelLabel
            // 
            this.SelectDataModelLabel.AutoSize = true;
            this.SelectDataModelLabel.Location = new System.Drawing.Point(8, 22);
            this.SelectDataModelLabel.Name = "SelectDataModelLabel";
            this.SelectDataModelLabel.Size = new System.Drawing.Size(237, 13);
            this.SelectDataModelLabel.TabIndex = 1;
            this.SelectDataModelLabel.Text = "Selecione um modelo de dados para gerenciá-lo:";
            // 
            // ManageableDataModelsComboBox
            // 
            this.ManageableDataModelsComboBox.FormattingEnabled = true;
            this.ManageableDataModelsComboBox.Location = new System.Drawing.Point(11, 50);
            this.ManageableDataModelsComboBox.Name = "ManageableDataModelsComboBox";
            this.ManageableDataModelsComboBox.Size = new System.Drawing.Size(234, 21);
            this.ManageableDataModelsComboBox.TabIndex = 2;
            // 
            // DeleteDataModelButton
            // 
            this.DeleteDataModelButton.Location = new System.Drawing.Point(11, 77);
            this.DeleteDataModelButton.Name = "DeleteDataModelButton";
            this.DeleteDataModelButton.Size = new System.Drawing.Size(234, 36);
            this.DeleteDataModelButton.TabIndex = 9;
            this.DeleteDataModelButton.Text = "Deletar este modelo de dados";
            this.DeleteDataModelButton.UseVisualStyleBackColor = true;
            // 
            // ChooseDataModelGroupBox
            // 
            this.ChooseDataModelGroupBox.Controls.Add(this.CreateDataModelRadioButton);
            this.ChooseDataModelGroupBox.Controls.Add(this.UpdateDataModelRadioButton);
            this.ChooseDataModelGroupBox.Location = new System.Drawing.Point(18, 20);
            this.ChooseDataModelGroupBox.Name = "ChooseDataModelGroupBox";
            this.ChooseDataModelGroupBox.Size = new System.Drawing.Size(784, 80);
            this.ChooseDataModelGroupBox.TabIndex = 12;
            this.ChooseDataModelGroupBox.TabStop = false;
            this.ChooseDataModelGroupBox.Text = "Selecione uma opção";
            // 
            // CreateDataModelRadioButton
            // 
            this.CreateDataModelRadioButton.AutoSize = true;
            this.CreateDataModelRadioButton.Checked = true;
            this.CreateDataModelRadioButton.Location = new System.Drawing.Point(10, 24);
            this.CreateDataModelRadioButton.Name = "CreateDataModelRadioButton";
            this.CreateDataModelRadioButton.Size = new System.Drawing.Size(157, 17);
            this.CreateDataModelRadioButton.TabIndex = 10;
            this.CreateDataModelRadioButton.TabStop = true;
            this.CreateDataModelRadioButton.Text = "Criar novo modelo de dados";
            this.CreateDataModelRadioButton.UseVisualStyleBackColor = true;
            this.CreateDataModelRadioButton.CheckedChanged += new System.EventHandler(this.CreateNewDataModelRadioButton_CheckedChanged);
            // 
            // UpdateDataModelRadioButton
            // 
            this.UpdateDataModelRadioButton.AutoSize = true;
            this.UpdateDataModelRadioButton.Location = new System.Drawing.Point(10, 47);
            this.UpdateDataModelRadioButton.Name = "UpdateDataModelRadioButton";
            this.UpdateDataModelRadioButton.Size = new System.Drawing.Size(193, 17);
            this.UpdateDataModelRadioButton.TabIndex = 11;
            this.UpdateDataModelRadioButton.Text = "Usar um modelo de dados existente";
            this.UpdateDataModelRadioButton.UseVisualStyleBackColor = true;
            this.UpdateDataModelRadioButton.CheckedChanged += new System.EventHandler(this.UpdateDataModelRadioButton_CheckedChanged);
            // 
            // DataModelUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DataModelPanel);
            this.Name = "DataModelUserControl";
            this.Size = new System.Drawing.Size(829, 533);
            this.DataModelPanel.ResumeLayout(false);
            this.DataModelInfoGroupBox.ResumeLayout(false);
            this.DataModelInfoGroupBox.PerformLayout();
            this.SelectDataModelPanel.ResumeLayout(false);
            this.SelectDataModelPanel.PerformLayout();
            this.ChooseDataModelGroupBox.ResumeLayout(false);
            this.ChooseDataModelGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel DataModelPanel;
        private System.Windows.Forms.Button SaveDataModelButton;
        private System.Windows.Forms.Button RemoveNewDataItemButton;
        private System.Windows.Forms.ListBox NewDataItemsListBox;
        private System.Windows.Forms.Button AddDataItemButton;
        private System.Windows.Forms.Label DataItemLabel;
        private System.Windows.Forms.TextBox DataItemTextBox;
        private System.Windows.Forms.Button DeleteDataModelButton;
        private System.Windows.Forms.ComboBox ManageableDataModelsComboBox;
        private System.Windows.Forms.Label SelectDataModelLabel;
        private System.Windows.Forms.GroupBox ChooseDataModelGroupBox;
        private System.Windows.Forms.RadioButton CreateDataModelRadioButton;
        private System.Windows.Forms.RadioButton UpdateDataModelRadioButton;
        private System.Windows.Forms.GroupBox DataModelInfoGroupBox;
        private System.Windows.Forms.Panel SelectDataModelPanel;
        private System.Windows.Forms.Label DataModelNameLabel;
        private System.Windows.Forms.TextBox DataModelNameTextBox;
    }
}
