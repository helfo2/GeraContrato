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
            this.tabControlDataModel = new System.Windows.Forms.TabControl();
            this.tabPageNewDataModel = new System.Windows.Forms.TabPage();
            this.lblAddingInfo = new System.Windows.Forms.Label();
            this.btnSaveDataModel = new System.Windows.Forms.Button();
            this.btnRemoveNewDataItem = new System.Windows.Forms.Button();
            this.listboxDataItems = new System.Windows.Forms.ListBox();
            this.btnAddDataItem = new System.Windows.Forms.Button();
            this.lblDataItemName = new System.Windows.Forms.Label();
            this.txtDataItemName = new System.Windows.Forms.TextBox();
            this.tabPageManageDataModels = new System.Windows.Forms.TabPage();
            this.btnDeleteDataModel = new System.Windows.Forms.Button();
            this.btnSaveDataModelChanges = new System.Windows.Forms.Button();
            this.btnRemoveSelectedDataItem = new System.Windows.Forms.Button();
            this.listBoxDataModelItems = new System.Windows.Forms.ListBox();
            this.cmbManageableDataModels = new System.Windows.Forms.ComboBox();
            this.lblSelectDataModel = new System.Windows.Forms.Label();
            this.DataModelPanel.SuspendLayout();
            this.tabControlDataModel.SuspendLayout();
            this.tabPageNewDataModel.SuspendLayout();
            this.tabPageManageDataModels.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataModelPanel
            // 
            this.DataModelPanel.Controls.Add(this.tabControlDataModel);
            this.DataModelPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataModelPanel.Location = new System.Drawing.Point(0, 0);
            this.DataModelPanel.Name = "DataModelPanel";
            this.DataModelPanel.Size = new System.Drawing.Size(635, 408);
            this.DataModelPanel.TabIndex = 0;
            // 
            // tabControlDataModel
            // 
            this.tabControlDataModel.Controls.Add(this.tabPageNewDataModel);
            this.tabControlDataModel.Controls.Add(this.tabPageManageDataModels);
            this.tabControlDataModel.Location = new System.Drawing.Point(20, 35);
            this.tabControlDataModel.Name = "tabControlDataModel";
            this.tabControlDataModel.SelectedIndex = 0;
            this.tabControlDataModel.Size = new System.Drawing.Size(595, 338);
            this.tabControlDataModel.TabIndex = 8;
            // 
            // tabPageNewDataModel
            // 
            this.tabPageNewDataModel.Controls.Add(this.lblAddingInfo);
            this.tabPageNewDataModel.Controls.Add(this.btnSaveDataModel);
            this.tabPageNewDataModel.Controls.Add(this.btnRemoveNewDataItem);
            this.tabPageNewDataModel.Controls.Add(this.listboxDataItems);
            this.tabPageNewDataModel.Controls.Add(this.btnAddDataItem);
            this.tabPageNewDataModel.Controls.Add(this.lblDataItemName);
            this.tabPageNewDataModel.Controls.Add(this.txtDataItemName);
            this.tabPageNewDataModel.Location = new System.Drawing.Point(4, 22);
            this.tabPageNewDataModel.Name = "tabPageNewDataModel";
            this.tabPageNewDataModel.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNewDataModel.Size = new System.Drawing.Size(587, 312);
            this.tabPageNewDataModel.TabIndex = 0;
            this.tabPageNewDataModel.Text = "Novo";
            this.tabPageNewDataModel.UseVisualStyleBackColor = true;
            // 
            // lblAddingInfo
            // 
            this.lblAddingInfo.AutoSize = true;
            this.lblAddingInfo.Location = new System.Drawing.Point(6, 12);
            this.lblAddingInfo.Name = "lblAddingInfo";
            this.lblAddingInfo.Size = new System.Drawing.Size(320, 13);
            this.lblAddingInfo.TabIndex = 0;
            this.lblAddingInfo.Text = "Adicione os campos conforme o necessário (a ordem não importa):";
            // 
            // btnSaveDataModel
            // 
            this.btnSaveDataModel.Location = new System.Drawing.Point(420, 241);
            this.btnSaveDataModel.Name = "btnSaveDataModel";
            this.btnSaveDataModel.Size = new System.Drawing.Size(161, 65);
            this.btnSaveDataModel.TabIndex = 5;
            this.btnSaveDataModel.Text = "Criar modelo de dados";
            this.btnSaveDataModel.UseVisualStyleBackColor = true;
            // 
            // btnRemoveNewDataItem
            // 
            this.btnRemoveNewDataItem.Location = new System.Drawing.Point(265, 222);
            this.btnRemoveNewDataItem.Name = "btnRemoveNewDataItem";
            this.btnRemoveNewDataItem.Size = new System.Drawing.Size(90, 39);
            this.btnRemoveNewDataItem.TabIndex = 6;
            this.btnRemoveNewDataItem.Text = "Remover selecionado";
            this.btnRemoveNewDataItem.UseVisualStyleBackColor = true;
            // 
            // listboxDataItems
            // 
            this.listboxDataItems.FormattingEnabled = true;
            this.listboxDataItems.Location = new System.Drawing.Point(75, 101);
            this.listboxDataItems.Name = "listboxDataItems";
            this.listboxDataItems.Size = new System.Drawing.Size(174, 160);
            this.listboxDataItems.TabIndex = 1;
            // 
            // btnAddDataItem
            // 
            this.btnAddDataItem.Location = new System.Drawing.Point(265, 56);
            this.btnAddDataItem.Name = "btnAddDataItem";
            this.btnAddDataItem.Size = new System.Drawing.Size(90, 39);
            this.btnAddDataItem.TabIndex = 2;
            this.btnAddDataItem.Text = "Adicionar campo";
            this.btnAddDataItem.UseVisualStyleBackColor = true;
            // 
            // lblDataItemName
            // 
            this.lblDataItemName.AutoSize = true;
            this.lblDataItemName.Location = new System.Drawing.Point(70, 56);
            this.lblDataItemName.Name = "lblDataItemName";
            this.lblDataItemName.Size = new System.Drawing.Size(118, 13);
            this.lblDataItemName.TabIndex = 4;
            this.lblDataItemName.Text = "Identificador do campo:";
            // 
            // txtDataItemName
            // 
            this.txtDataItemName.Location = new System.Drawing.Point(73, 75);
            this.txtDataItemName.Name = "txtDataItemName";
            this.txtDataItemName.Size = new System.Drawing.Size(176, 20);
            this.txtDataItemName.TabIndex = 3;
            // 
            // tabPageManageDataModels
            // 
            this.tabPageManageDataModels.Controls.Add(this.btnDeleteDataModel);
            this.tabPageManageDataModels.Controls.Add(this.btnSaveDataModelChanges);
            this.tabPageManageDataModels.Controls.Add(this.btnRemoveSelectedDataItem);
            this.tabPageManageDataModels.Controls.Add(this.listBoxDataModelItems);
            this.tabPageManageDataModels.Controls.Add(this.cmbManageableDataModels);
            this.tabPageManageDataModels.Controls.Add(this.lblSelectDataModel);
            this.tabPageManageDataModels.Location = new System.Drawing.Point(4, 22);
            this.tabPageManageDataModels.Name = "tabPageManageDataModels";
            this.tabPageManageDataModels.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageManageDataModels.Size = new System.Drawing.Size(587, 312);
            this.tabPageManageDataModels.TabIndex = 1;
            this.tabPageManageDataModels.Text = "Gerenciar";
            this.tabPageManageDataModels.UseVisualStyleBackColor = true;
            // 
            // btnDeleteDataModel
            // 
            this.btnDeleteDataModel.Location = new System.Drawing.Point(391, 8);
            this.btnDeleteDataModel.Name = "btnDeleteDataModel";
            this.btnDeleteDataModel.Size = new System.Drawing.Size(108, 36);
            this.btnDeleteDataModel.TabIndex = 9;
            this.btnDeleteDataModel.Text = "Deletar este modelo de dados";
            this.btnDeleteDataModel.UseVisualStyleBackColor = true;
            // 
            // btnSaveDataModelChanges
            // 
            this.btnSaveDataModelChanges.Location = new System.Drawing.Point(420, 241);
            this.btnSaveDataModelChanges.Name = "btnSaveDataModelChanges";
            this.btnSaveDataModelChanges.Size = new System.Drawing.Size(161, 65);
            this.btnSaveDataModelChanges.TabIndex = 8;
            this.btnSaveDataModelChanges.Text = "Salvar modelo de dados";
            this.btnSaveDataModelChanges.UseVisualStyleBackColor = true;
            // 
            // btnRemoveSelectedDataItem
            // 
            this.btnRemoveSelectedDataItem.Location = new System.Drawing.Point(255, 208);
            this.btnRemoveSelectedDataItem.Name = "btnRemoveSelectedDataItem";
            this.btnRemoveSelectedDataItem.Size = new System.Drawing.Size(90, 39);
            this.btnRemoveSelectedDataItem.TabIndex = 7;
            this.btnRemoveSelectedDataItem.Text = "Remover selecionado";
            this.btnRemoveSelectedDataItem.UseVisualStyleBackColor = true;
            // 
            // listBoxDataModelItems
            // 
            this.listBoxDataModelItems.FormattingEnabled = true;
            this.listBoxDataModelItems.Location = new System.Drawing.Point(24, 61);
            this.listBoxDataModelItems.Name = "listBoxDataModelItems";
            this.listBoxDataModelItems.Size = new System.Drawing.Size(225, 186);
            this.listBoxDataModelItems.TabIndex = 3;
            // 
            // cmbManageableDataModels
            // 
            this.cmbManageableDataModels.FormattingEnabled = true;
            this.cmbManageableDataModels.Location = new System.Drawing.Point(264, 17);
            this.cmbManageableDataModels.Name = "cmbManageableDataModels";
            this.cmbManageableDataModels.Size = new System.Drawing.Size(121, 21);
            this.cmbManageableDataModels.TabIndex = 2;
            // 
            // lblSelectDataModel
            // 
            this.lblSelectDataModel.AutoSize = true;
            this.lblSelectDataModel.Location = new System.Drawing.Point(21, 20);
            this.lblSelectDataModel.Name = "lblSelectDataModel";
            this.lblSelectDataModel.Size = new System.Drawing.Size(237, 13);
            this.lblSelectDataModel.TabIndex = 1;
            this.lblSelectDataModel.Text = "Selecione um modelo de dados para gerenciá-lo:";
            // 
            // DataModelUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DataModelPanel);
            this.Name = "DataModelUserControl";
            this.Size = new System.Drawing.Size(635, 408);
            this.DataModelPanel.ResumeLayout(false);
            this.tabControlDataModel.ResumeLayout(false);
            this.tabPageNewDataModel.ResumeLayout(false);
            this.tabPageNewDataModel.PerformLayout();
            this.tabPageManageDataModels.ResumeLayout(false);
            this.tabPageManageDataModels.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel DataModelPanel;
        private System.Windows.Forms.TabControl tabControlDataModel;
        private System.Windows.Forms.TabPage tabPageNewDataModel;
        private System.Windows.Forms.Label lblAddingInfo;
        private System.Windows.Forms.Button btnSaveDataModel;
        private System.Windows.Forms.Button btnRemoveNewDataItem;
        private System.Windows.Forms.ListBox listboxDataItems;
        private System.Windows.Forms.Button btnAddDataItem;
        private System.Windows.Forms.Label lblDataItemName;
        private System.Windows.Forms.TextBox txtDataItemName;
        private System.Windows.Forms.TabPage tabPageManageDataModels;
        private System.Windows.Forms.Button btnDeleteDataModel;
        private System.Windows.Forms.Button btnSaveDataModelChanges;
        private System.Windows.Forms.Button btnRemoveSelectedDataItem;
        private System.Windows.Forms.ListBox listBoxDataModelItems;
        private System.Windows.Forms.ComboBox cmbManageableDataModels;
        private System.Windows.Forms.Label lblSelectDataModel;
    }
}
