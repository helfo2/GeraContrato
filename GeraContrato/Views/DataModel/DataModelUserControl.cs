using System;
using System.Windows.Forms;
using GeraContrato.Views.DataModel;
using GeraContrato.Presenters;

namespace GeraContrato.Views
{
    public partial class DataModelUserControl : UserControl, IDataModel
    {

        #region Interface
        
        public string Name
        {
            get
            {
                return DataModelNameTextBox.Text;
            }

            set
            {
                if(DataModelNameTextBox.Text != value)
                {
                    DataModelNameTextBox.Text = value;
                }
            }
        }

        /// <summary>
        /// The new item name.
        /// </summary>
        public string Item
        {
            get
            {
                return DataItemTextBox.Text;
            }
            set
            {
                if(DataItemTextBox.Text != value)
                {
                    DataItemTextBox.Text = value;
                }
            }
        }               

        /// <summary>
        /// All itens list.
        /// </summary>
        public ListBox DataItems
        {
            get
            {
                return NewDataItemsListBox;
            }            
        }

        public string NewSelectedItem
        {
            get
            {
                return NewDataItemsListBox.SelectedItem.ToString();
            }            
        }    

        #endregion

        #region Private properties

        private DataModelPresenter dataModelPresenter;

        private BindingSource dataItemsSource;

        #endregion

        public DataModelUserControl()
        {
            InitializeComponent();            
            dataModelPresenter = new DataModelPresenter(this);

            SetDefaultConfig();
        }

        private void SetDefaultConfig()
        {
            dataItemsSource = new BindingSource
            {
                DataSource = DataItems
            };

            SelectDataModelPanel.Hide();
            DataModelInfoGroupBox.Show();
            DeleteDataModelButton.Hide();
        }

        private void AddDataItemButton_Click(object sender, EventArgs e)
        {
            dataModelPresenter.AddItemToList();
            dataItemsSource.ResetBindings(false);
        }

        private void RemoveNewDataItemButton_Click(object sender, EventArgs e)
        {
            dataModelPresenter.RemoveItemFromList();
            dataItemsSource.ResetBindings(false);
        }

        private void CreateNewDataModelRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(CreateDataModelRadioButton.Checked)
            {
                SelectDataModelPanel.Hide();
                DataModelInfoGroupBox.Show();
            }            
        }

        private void UpdateDataModelRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (UpdateDataModelRadioButton.Checked)
            {
                SelectDataModelPanel.Show();
                DataModelInfoGroupBox.Hide();
            }            
        }

        private void SaveDataModelButton_Click(object sender, EventArgs e)
        {
            dataModelPresenter.CommitNew();
        }

        private void DataModelPanel_Paint(object sender, PaintEventArgs e)
        {
            DataModelNameTextBox.Text = "";
            DataModelNameTextBox.Focus();
        }
    }
}
