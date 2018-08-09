using System;
using System.Windows.Forms;
using GeraContrato.Views;
using GeraContrato.Views.Main;
using GeraContrato.Views.Shared;
using GeraContrato.Presenters;

namespace GeraContrato
{
    public partial class MainView : Form, IMainView
    {
        #region Properties 

        DataModelPresenter dataModelPresenter;

        #endregion

        #region Controls

        /// <summary>
        /// Contracts UI.
        /// </summary>
        ContractUserControl contractUserControl;

        /// <summary>
        /// Contract Models UI.
        /// </summary>
        ContractModelUserControl contractModelUserControl;

        /// <summary>
        /// Data Models UI.
        /// </summary>
        DataModelUserControl dataModelUserControl;

        #endregion

        #region Interface

        public Panel NavPanel
        {
            get
            {
                return this.MainPanel;
            }

            set
            {
                if(this.MainPanel != value)
                {
                    this.MainPanel = value;
                }
            }
        }

        #endregion

        public MainView()
        {
            InitializeComponent();

            InitializePanels();
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            NavPanel.Controls.Add(contractUserControl);
            NavPanel.Controls.Add(contractModelUserControl);
            NavPanel.Controls.Add(dataModelUserControl);            
        }

        private void ContractsButton_Click(object sender, EventArgs e)
        {
            ToogleNavPanel(sender, e);
        }

        private void ContractModelsButton_Click(object sender, EventArgs e)
        {
            ToogleNavPanel(sender, e);
        }

        private void DataModelsButton_Click(object sender, EventArgs e)
        {
            ToogleNavPanel(sender, e);
        }

        #region UI Methods

        private void InitializePanels()
        {
            contractUserControl = new ContractUserControl();
            contractModelUserControl = new ContractModelUserControl();
            dataModelUserControl = new DataModelUserControl();

            contractModelUserControl.Hide();
            contractUserControl.Hide();
            dataModelUserControl.Hide();
        }

        private void ToogleNavPanel(object sender, EventArgs e)
        {
            foreach(UserControl control in NavPanel.Controls)
            {
                control.Hide();
            }

            try
            {
                NavPanel.Controls[GetControlIndex(sender as Button)].Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro nos controles", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private int GetControlIndex(Button btn)
        {            
            switch (btn.Name)
            {
                case "ContractsButton":
                    return (int)UserControlIndex.Contracts;                    
                case "ContractModelsButton":
                    return (int)UserControlIndex.ContractModels;                    
                case "DataModelsButton":
                    return (int)UserControlIndex.DataModels;                    
                default: return -1;                    
            }
        }

        #endregion
    }
}
