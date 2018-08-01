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
            this.tabControlContractModels = new System.Windows.Forms.TabControl();
            this.tabPageNewContractModel = new System.Windows.Forms.TabPage();
            this.btnNewContractModel = new System.Windows.Forms.Button();
            this.lblInsertText = new System.Windows.Forms.Label();
            this.txtContractModel = new System.Windows.Forms.RichTextBox();
            this.tabPageManageContractModels = new System.Windows.Forms.TabPage();
            this.btnUpdateContractModel = new System.Windows.Forms.Button();
            this.richTextBoxUpdateContractModel = new System.Windows.Forms.RichTextBox();
            this.btnRemoveContractModel = new System.Windows.Forms.Button();
            this.cmbManageableContractModels = new System.Windows.Forms.ComboBox();
            this.lblSelectContractModel = new System.Windows.Forms.Label();
            this.ContractPanel.SuspendLayout();
            this.tabControlContractModels.SuspendLayout();
            this.tabPageNewContractModel.SuspendLayout();
            this.tabPageManageContractModels.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContractPanel
            // 
            this.ContractPanel.Controls.Add(this.tabControlContractModels);
            this.ContractPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContractPanel.Location = new System.Drawing.Point(0, 0);
            this.ContractPanel.Name = "ContractPanel";
            this.ContractPanel.Size = new System.Drawing.Size(808, 433);
            this.ContractPanel.TabIndex = 0;
            // 
            // tabControlContractModels
            // 
            this.tabControlContractModels.Controls.Add(this.tabPageNewContractModel);
            this.tabControlContractModels.Controls.Add(this.tabPageManageContractModels);
            this.tabControlContractModels.Location = new System.Drawing.Point(60, 31);
            this.tabControlContractModels.Name = "tabControlContractModels";
            this.tabControlContractModels.SelectedIndex = 0;
            this.tabControlContractModels.Size = new System.Drawing.Size(689, 381);
            this.tabControlContractModels.TabIndex = 3;
            // 
            // tabPageNewContractModel
            // 
            this.tabPageNewContractModel.Controls.Add(this.btnNewContractModel);
            this.tabPageNewContractModel.Controls.Add(this.lblInsertText);
            this.tabPageNewContractModel.Controls.Add(this.txtContractModel);
            this.tabPageNewContractModel.Location = new System.Drawing.Point(4, 22);
            this.tabPageNewContractModel.Name = "tabPageNewContractModel";
            this.tabPageNewContractModel.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNewContractModel.Size = new System.Drawing.Size(681, 355);
            this.tabPageNewContractModel.TabIndex = 0;
            this.tabPageNewContractModel.Text = "Novo";
            this.tabPageNewContractModel.UseVisualStyleBackColor = true;
            // 
            // btnNewContractModel
            // 
            this.btnNewContractModel.Location = new System.Drawing.Point(527, 268);
            this.btnNewContractModel.Name = "btnNewContractModel";
            this.btnNewContractModel.Size = new System.Drawing.Size(100, 38);
            this.btnNewContractModel.TabIndex = 2;
            this.btnNewContractModel.Text = "Criar modelo de contratos";
            this.btnNewContractModel.UseVisualStyleBackColor = true;
            this.btnNewContractModel.Click += new System.EventHandler(this.btnNewContractModel_Click);
            // 
            // lblInsertText
            // 
            this.lblInsertText.AutoSize = true;
            this.lblInsertText.Location = new System.Drawing.Point(5, 18);
            this.lblInsertText.Name = "lblInsertText";
            this.lblInsertText.Size = new System.Drawing.Size(118, 13);
            this.lblInsertText.TabIndex = 0;
            this.lblInsertText.Text = "Por favor, insira o texto:";
            // 
            // txtContractModel
            // 
            this.txtContractModel.Location = new System.Drawing.Point(129, 15);
            this.txtContractModel.Name = "txtContractModel";
            this.txtContractModel.Size = new System.Drawing.Size(392, 299);
            this.txtContractModel.TabIndex = 1;
            this.txtContractModel.Text = "";
            // 
            // tabPageManageContractModels
            // 
            this.tabPageManageContractModels.Controls.Add(this.btnUpdateContractModel);
            this.tabPageManageContractModels.Controls.Add(this.richTextBoxUpdateContractModel);
            this.tabPageManageContractModels.Controls.Add(this.btnRemoveContractModel);
            this.tabPageManageContractModels.Controls.Add(this.cmbManageableContractModels);
            this.tabPageManageContractModels.Controls.Add(this.lblSelectContractModel);
            this.tabPageManageContractModels.Location = new System.Drawing.Point(4, 22);
            this.tabPageManageContractModels.Name = "tabPageManageContractModels";
            this.tabPageManageContractModels.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageManageContractModels.Size = new System.Drawing.Size(681, 355);
            this.tabPageManageContractModels.TabIndex = 1;
            this.tabPageManageContractModels.Text = "Gerenciar";
            this.tabPageManageContractModels.UseVisualStyleBackColor = true;
            // 
            // btnUpdateContractModel
            // 
            this.btnUpdateContractModel.Location = new System.Drawing.Point(517, 293);
            this.btnUpdateContractModel.Name = "btnUpdateContractModel";
            this.btnUpdateContractModel.Size = new System.Drawing.Size(130, 43);
            this.btnUpdateContractModel.TabIndex = 14;
            this.btnUpdateContractModel.Text = "Salvar modelo de contratos";
            this.btnUpdateContractModel.UseVisualStyleBackColor = true;
            // 
            // richTextBoxUpdateContractModel
            // 
            this.richTextBoxUpdateContractModel.Location = new System.Drawing.Point(21, 65);
            this.richTextBoxUpdateContractModel.Name = "richTextBoxUpdateContractModel";
            this.richTextBoxUpdateContractModel.Size = new System.Drawing.Size(356, 271);
            this.richTextBoxUpdateContractModel.TabIndex = 13;
            this.richTextBoxUpdateContractModel.Text = "";
            // 
            // btnRemoveContractModel
            // 
            this.btnRemoveContractModel.Location = new System.Drawing.Point(403, 14);
            this.btnRemoveContractModel.Name = "btnRemoveContractModel";
            this.btnRemoveContractModel.Size = new System.Drawing.Size(130, 50);
            this.btnRemoveContractModel.TabIndex = 12;
            this.btnRemoveContractModel.Text = "Deletar este modelo de contratos";
            this.btnRemoveContractModel.UseVisualStyleBackColor = true;
            // 
            // cmbManageableContractModels
            // 
            this.cmbManageableContractModels.FormattingEnabled = true;
            this.cmbManageableContractModels.Location = new System.Drawing.Point(276, 23);
            this.cmbManageableContractModels.Name = "cmbManageableContractModels";
            this.cmbManageableContractModels.Size = new System.Drawing.Size(121, 21);
            this.cmbManageableContractModels.TabIndex = 11;
            // 
            // lblSelectContractModel
            // 
            this.lblSelectContractModel.AutoSize = true;
            this.lblSelectContractModel.Location = new System.Drawing.Point(18, 26);
            this.lblSelectContractModel.Name = "lblSelectContractModel";
            this.lblSelectContractModel.Size = new System.Drawing.Size(252, 13);
            this.lblSelectContractModel.TabIndex = 10;
            this.lblSelectContractModel.Text = "Selecione um modelo de contratos para gerenciá-lo:";
            // 
            // ContractModelUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ContractPanel);
            this.Name = "ContractModelUserControl";
            this.Size = new System.Drawing.Size(808, 433);
            this.ContractPanel.ResumeLayout(false);
            this.tabControlContractModels.ResumeLayout(false);
            this.tabPageNewContractModel.ResumeLayout(false);
            this.tabPageNewContractModel.PerformLayout();
            this.tabPageManageContractModels.ResumeLayout(false);
            this.tabPageManageContractModels.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ContractPanel;
        private System.Windows.Forms.TabControl tabControlContractModels;
        private System.Windows.Forms.TabPage tabPageNewContractModel;
        private System.Windows.Forms.Button btnNewContractModel;
        private System.Windows.Forms.Label lblInsertText;
        private System.Windows.Forms.RichTextBox txtContractModel;
        private System.Windows.Forms.TabPage tabPageManageContractModels;
        private System.Windows.Forms.Button btnUpdateContractModel;
        private System.Windows.Forms.RichTextBox richTextBoxUpdateContractModel;
        private System.Windows.Forms.Button btnRemoveContractModel;
        private System.Windows.Forms.ComboBox cmbManageableContractModels;
        private System.Windows.Forms.Label lblSelectContractModel;
    }
}
