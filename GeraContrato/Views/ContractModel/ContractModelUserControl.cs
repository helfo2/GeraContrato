using GeraContrato.Views.ContractModel;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GeraContrato.Views
{
    public partial class ContractModelUserControl : UserControl, IContractModel
    {
        #region Interface

        /// <summary>
        /// The contract text
        /// </summary>
        public string ContractText
        {
            get
            {
                return ContractModelTextBox.Text;
            }
            set
            {
                if(ContractModelTextBox.Text != value)
                {
                    ContractModelTextBox.Text = value;
                }
            }
        }

        /// <summary>
        /// The contract blanks to be replaced
        /// </summary>
        public List<int> BlankPositions
        {
            get
            {
                return null;
            }
            set
            {

            }
        }

        #endregion

        #region Private properties

        private BindingSource contractTextSource;

        #endregion

        public ContractModelUserControl()
        {
            InitializeComponent();

            SetDefaultConfig();
        }
        
        private void SetDefaultConfig()
        {
            contractTextSource = new BindingSource
            {
                DataSource = ContractText
            };

            SelectContractModelPanel.Hide();
            ContractModelInfoGroupBox.Show();
            DeleteContractModelButton.Hide();
        }

        private void CreateContractModelRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (CreateContractModelRadioButton.Checked)
            {
                SelectContractModelPanel.Hide();
                ContractModelInfoGroupBox.Show();
            }
        }

        private void UpdateContractModelRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (UpdateContractModelRadioButton.Checked)
            {
                SelectContractModelPanel.Show();
                ContractModelInfoGroupBox.Hide();
            }
        }
    }
}
