namespace GeraContrato
{
    partial class MainView
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainMenuPanel = new System.Windows.Forms.Panel();
            this.HelpLabel = new System.Windows.Forms.LinkLabel();
            this.DataModelsButton = new System.Windows.Forms.Button();
            this.ContractModelsButton = new System.Windows.Forms.Button();
            this.ContractsButton = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.MainMenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenuPanel
            // 
            this.MainMenuPanel.Controls.Add(this.HelpLabel);
            this.MainMenuPanel.Controls.Add(this.DataModelsButton);
            this.MainMenuPanel.Controls.Add(this.ContractModelsButton);
            this.MainMenuPanel.Controls.Add(this.ContractsButton);
            this.MainMenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MainMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MainMenuPanel.Name = "MainMenuPanel";
            this.MainMenuPanel.Size = new System.Drawing.Size(146, 465);
            this.MainMenuPanel.TabIndex = 0;
            // 
            // HelpLabel
            // 
            this.HelpLabel.AutoSize = true;
            this.HelpLabel.Location = new System.Drawing.Point(54, 347);
            this.HelpLabel.Name = "HelpLabel";
            this.HelpLabel.Size = new System.Drawing.Size(34, 13);
            this.HelpLabel.TabIndex = 3;
            this.HelpLabel.TabStop = true;
            this.HelpLabel.Text = "Ajuda";
            // 
            // DataModelsButton
            // 
            this.DataModelsButton.Location = new System.Drawing.Point(0, 136);
            this.DataModelsButton.Name = "DataModelsButton";
            this.DataModelsButton.Size = new System.Drawing.Size(146, 62);
            this.DataModelsButton.TabIndex = 2;
            this.DataModelsButton.Text = "Modelo de Dados";
            this.DataModelsButton.UseVisualStyleBackColor = true;
            this.DataModelsButton.Click += new System.EventHandler(this.DataModelsButton_Click);
            // 
            // ContractModelsButton
            // 
            this.ContractModelsButton.Location = new System.Drawing.Point(0, 68);
            this.ContractModelsButton.Name = "ContractModelsButton";
            this.ContractModelsButton.Size = new System.Drawing.Size(146, 62);
            this.ContractModelsButton.TabIndex = 1;
            this.ContractModelsButton.Text = "Modelo de Contratos";
            this.ContractModelsButton.UseVisualStyleBackColor = true;
            this.ContractModelsButton.Click += new System.EventHandler(this.ContractModelsButton_Click);
            // 
            // ContractsButton
            // 
            this.ContractsButton.Location = new System.Drawing.Point(0, 0);
            this.ContractsButton.Name = "ContractsButton";
            this.ContractsButton.Size = new System.Drawing.Size(146, 62);
            this.ContractsButton.TabIndex = 0;
            this.ContractsButton.Text = "Novo Contrato";
            this.ContractsButton.UseVisualStyleBackColor = true;
            this.ContractsButton.Click += new System.EventHandler(this.ContractsButton_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(146, 0);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(777, 465);
            this.MainPanel.TabIndex = 4;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 465);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.MainMenuPanel);
            this.Name = "MainView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gera Contrato 1.0";
            this.Load += new System.EventHandler(this.MainView_Load);
            this.MainMenuPanel.ResumeLayout(false);
            this.MainMenuPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainMenuPanel;
        private System.Windows.Forms.LinkLabel HelpLabel;
        private System.Windows.Forms.Button DataModelsButton;
        private System.Windows.Forms.Button ContractModelsButton;
        private System.Windows.Forms.Button ContractsButton;
        private System.Windows.Forms.Panel MainPanel;
    }
}

