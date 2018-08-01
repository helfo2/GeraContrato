namespace GeraContrato.Views
{
    partial class ContractUserControl
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
            this.cmbDataModels = new System.Windows.Forms.ComboBox();
            this.lblDataModel = new System.Windows.Forms.Label();
            this.cmbContractModels = new System.Windows.Forms.ComboBox();
            this.lblContractModel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbDataModels
            // 
            this.cmbDataModels.FormattingEnabled = true;
            this.cmbDataModels.Location = new System.Drawing.Point(518, 51);
            this.cmbDataModels.Name = "cmbDataModels";
            this.cmbDataModels.Size = new System.Drawing.Size(121, 21);
            this.cmbDataModels.TabIndex = 7;
            // 
            // lblDataModel
            // 
            this.lblDataModel.AutoSize = true;
            this.lblDataModel.Location = new System.Drawing.Point(409, 54);
            this.lblDataModel.Name = "lblDataModel";
            this.lblDataModel.Size = new System.Drawing.Size(94, 13);
            this.lblDataModel.TabIndex = 6;
            this.lblDataModel.Text = "Modelo de Dados:";
            // 
            // cmbContractModels
            // 
            this.cmbContractModels.FormattingEnabled = true;
            this.cmbContractModels.Location = new System.Drawing.Point(150, 51);
            this.cmbContractModels.Name = "cmbContractModels";
            this.cmbContractModels.Size = new System.Drawing.Size(121, 21);
            this.cmbContractModels.TabIndex = 5;
            // 
            // lblContractModel
            // 
            this.lblContractModel.AutoSize = true;
            this.lblContractModel.Location = new System.Drawing.Point(41, 54);
            this.lblContractModel.Name = "lblContractModel";
            this.lblContractModel.Size = new System.Drawing.Size(103, 13);
            this.lblContractModel.TabIndex = 4;
            this.lblContractModel.Text = "Modelo de Contrato:";
            // 
            // ContractUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbDataModels);
            this.Controls.Add(this.lblDataModel);
            this.Controls.Add(this.cmbContractModels);
            this.Controls.Add(this.lblContractModel);
            this.Name = "ContractUserControl";
            this.Size = new System.Drawing.Size(723, 420);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDataModels;
        private System.Windows.Forms.Label lblDataModel;
        private System.Windows.Forms.ComboBox cmbContractModels;
        private System.Windows.Forms.Label lblContractModel;
    }
}
