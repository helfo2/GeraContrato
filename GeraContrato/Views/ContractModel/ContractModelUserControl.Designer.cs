namespace GeraContrato.Views
{
    partial class ContractModelUserControl
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
            this.ContractPanel = new System.Windows.Forms.Panel();
            this.ContractModelInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.SaveContractModelButton = new System.Windows.Forms.Button();
            this.InsertContractTextLabel = new System.Windows.Forms.Label();
            this.ContractModelTextBox = new System.Windows.Forms.RichTextBox();
            this.SelectContractModelPanel = new System.Windows.Forms.Panel();
            this.SelectContractModelLabel = new System.Windows.Forms.Label();
            this.ManageableDataModelsComboBox = new System.Windows.Forms.ComboBox();
            this.DeleteContractModelButton = new System.Windows.Forms.Button();
            this.ChooseContractModelGroupBox = new System.Windows.Forms.GroupBox();
            this.CreateContractModelRadioButton = new System.Windows.Forms.RadioButton();
            this.UpdateContractModelRadioButton = new System.Windows.Forms.RadioButton();
            this.ContractPanel.SuspendLayout();
            this.ContractModelInfoGroupBox.SuspendLayout();
            this.SelectContractModelPanel.SuspendLayout();
            this.ChooseContractModelGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContractPanel
            // 
            this.ContractPanel.Controls.Add(this.ContractModelInfoGroupBox);
            this.ContractPanel.Controls.Add(this.SelectContractModelPanel);
            this.ContractPanel.Controls.Add(this.ChooseContractModelGroupBox);
            this.ContractPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContractPanel.Location = new System.Drawing.Point(0, 0);
            this.ContractPanel.Name = "ContractPanel";
            this.ContractPanel.Size = new System.Drawing.Size(829, 533);
            this.ContractPanel.TabIndex = 0;
            // 
            // ContractModelInfoGroupBox
            // 
            this.ContractModelInfoGroupBox.Controls.Add(this.SaveContractModelButton);
            this.ContractModelInfoGroupBox.Controls.Add(this.InsertContractTextLabel);
            this.ContractModelInfoGroupBox.Controls.Add(this.ContractModelTextBox);
            this.ContractModelInfoGroupBox.Location = new System.Drawing.Point(299, 106);
            this.ContractModelInfoGroupBox.Name = "ContractModelInfoGroupBox";
            this.ContractModelInfoGroupBox.Size = new System.Drawing.Size(503, 394);
            this.ContractModelInfoGroupBox.TabIndex = 15;
            this.ContractModelInfoGroupBox.TabStop = false;
            this.ContractModelInfoGroupBox.Text = "Modelo de Contratos";
            // 
            // SaveContractModelButton
            // 
            this.SaveContractModelButton.Location = new System.Drawing.Point(349, 343);
            this.SaveContractModelButton.Name = "SaveContractModelButton";
            this.SaveContractModelButton.Size = new System.Drawing.Size(100, 38);
            this.SaveContractModelButton.TabIndex = 5;
            this.SaveContractModelButton.Text = "Criar modelo de contratos";
            this.SaveContractModelButton.UseVisualStyleBackColor = true;
            // 
            // InsertContractTextLabel
            // 
            this.InsertContractTextLabel.AutoSize = true;
            this.InsertContractTextLabel.Location = new System.Drawing.Point(54, 35);
            this.InsertContractTextLabel.Name = "InsertContractTextLabel";
            this.InsertContractTextLabel.Size = new System.Drawing.Size(118, 13);
            this.InsertContractTextLabel.TabIndex = 3;
            this.InsertContractTextLabel.Text = "Por favor, insira o texto:";
            // 
            // ContractModelTextBox
            // 
            this.ContractModelTextBox.Location = new System.Drawing.Point(57, 62);
            this.ContractModelTextBox.Name = "ContractModelTextBox";
            this.ContractModelTextBox.Size = new System.Drawing.Size(392, 275);
            this.ContractModelTextBox.TabIndex = 4;
            this.ContractModelTextBox.Text = "";
            // 
            // SelectContractModelPanel
            // 
            this.SelectContractModelPanel.Controls.Add(this.SelectContractModelLabel);
            this.SelectContractModelPanel.Controls.Add(this.ManageableDataModelsComboBox);
            this.SelectContractModelPanel.Controls.Add(this.DeleteContractModelButton);
            this.SelectContractModelPanel.Location = new System.Drawing.Point(18, 106);
            this.SelectContractModelPanel.Name = "SelectContractModelPanel";
            this.SelectContractModelPanel.Size = new System.Drawing.Size(275, 202);
            this.SelectContractModelPanel.TabIndex = 14;
            // 
            // SelectContractModelLabel
            // 
            this.SelectContractModelLabel.AutoSize = true;
            this.SelectContractModelLabel.Location = new System.Drawing.Point(8, 22);
            this.SelectContractModelLabel.Name = "SelectContractModelLabel";
            this.SelectContractModelLabel.Size = new System.Drawing.Size(252, 13);
            this.SelectContractModelLabel.TabIndex = 1;
            this.SelectContractModelLabel.Text = "Selecione um modelo de contratos para gerenciá-lo:";
            // 
            // ManageableDataModelsComboBox
            // 
            this.ManageableDataModelsComboBox.FormattingEnabled = true;
            this.ManageableDataModelsComboBox.Location = new System.Drawing.Point(11, 50);
            this.ManageableDataModelsComboBox.Name = "ManageableDataModelsComboBox";
            this.ManageableDataModelsComboBox.Size = new System.Drawing.Size(234, 21);
            this.ManageableDataModelsComboBox.TabIndex = 2;
            // 
            // DeleteContractModelButton
            // 
            this.DeleteContractModelButton.Location = new System.Drawing.Point(11, 77);
            this.DeleteContractModelButton.Name = "DeleteContractModelButton";
            this.DeleteContractModelButton.Size = new System.Drawing.Size(234, 36);
            this.DeleteContractModelButton.TabIndex = 9;
            this.DeleteContractModelButton.Text = "Deletar este modelo de contratos";
            this.DeleteContractModelButton.UseVisualStyleBackColor = true;
            // 
            // ChooseContractModelGroupBox
            // 
            this.ChooseContractModelGroupBox.Controls.Add(this.CreateContractModelRadioButton);
            this.ChooseContractModelGroupBox.Controls.Add(this.UpdateContractModelRadioButton);
            this.ChooseContractModelGroupBox.Location = new System.Drawing.Point(18, 20);
            this.ChooseContractModelGroupBox.Name = "ChooseContractModelGroupBox";
            this.ChooseContractModelGroupBox.Size = new System.Drawing.Size(784, 80);
            this.ChooseContractModelGroupBox.TabIndex = 13;
            this.ChooseContractModelGroupBox.TabStop = false;
            this.ChooseContractModelGroupBox.Text = "Selecione uma opção";
            // 
            // CreateContractModelRadioButton
            // 
            this.CreateContractModelRadioButton.AutoSize = true;
            this.CreateContractModelRadioButton.Checked = true;
            this.CreateContractModelRadioButton.Location = new System.Drawing.Point(10, 24);
            this.CreateContractModelRadioButton.Name = "CreateContractModelRadioButton";
            this.CreateContractModelRadioButton.Size = new System.Drawing.Size(172, 17);
            this.CreateContractModelRadioButton.TabIndex = 10;
            this.CreateContractModelRadioButton.TabStop = true;
            this.CreateContractModelRadioButton.Text = "Criar novo modelo de contratos";
            this.CreateContractModelRadioButton.UseVisualStyleBackColor = true;
            this.CreateContractModelRadioButton.CheckedChanged += new System.EventHandler(this.CreateContractModelRadioButton_CheckedChanged);
            // 
            // UpdateContractModelRadioButton
            // 
            this.UpdateContractModelRadioButton.AutoSize = true;
            this.UpdateContractModelRadioButton.Location = new System.Drawing.Point(10, 47);
            this.UpdateContractModelRadioButton.Name = "UpdateContractModelRadioButton";
            this.UpdateContractModelRadioButton.Size = new System.Drawing.Size(208, 17);
            this.UpdateContractModelRadioButton.TabIndex = 11;
            this.UpdateContractModelRadioButton.Text = "Usar um modelo de contratos existente";
            this.UpdateContractModelRadioButton.UseVisualStyleBackColor = true;
            this.UpdateContractModelRadioButton.CheckedChanged += new System.EventHandler(this.UpdateContractModelRadioButton_CheckedChanged);
            // 
            // ContractModelUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ContractPanel);
            this.Name = "ContractModelUserControl";
            this.Size = new System.Drawing.Size(829, 533);
            this.ContractPanel.ResumeLayout(false);
            this.ContractModelInfoGroupBox.ResumeLayout(false);
            this.ContractModelInfoGroupBox.PerformLayout();
            this.SelectContractModelPanel.ResumeLayout(false);
            this.SelectContractModelPanel.PerformLayout();
            this.ChooseContractModelGroupBox.ResumeLayout(false);
            this.ChooseContractModelGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ContractPanel;
        private System.Windows.Forms.GroupBox ChooseContractModelGroupBox;
        private System.Windows.Forms.RadioButton CreateContractModelRadioButton;
        private System.Windows.Forms.RadioButton UpdateContractModelRadioButton;
        private System.Windows.Forms.Panel SelectContractModelPanel;
        private System.Windows.Forms.Label SelectContractModelLabel;
        private System.Windows.Forms.ComboBox ManageableDataModelsComboBox;
        private System.Windows.Forms.Button DeleteContractModelButton;
        private System.Windows.Forms.GroupBox ContractModelInfoGroupBox;
        private System.Windows.Forms.Button SaveContractModelButton;
        private System.Windows.Forms.Label InsertContractTextLabel;
        private System.Windows.Forms.RichTextBox ContractModelTextBox;
    }
}
