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

        public string SelectedNewItem
        {
            get
            {
                return NewDataItemsListBox.SelectedItem.ToString();
            }            
        }

        public ComboBox DataModels
        {
            get
            {
                return ManageableDataModelsComboBox;
            }

            set
            {
                if(ManageableDataModelsComboBox != value)
                {
                    ManageableDataModelsComboBox = value;
                }
            }
        }

        public int? Id
        {
            get
            {
                return int.Parse(IdLabel.Text);
            }
            set
            {
                if(value.HasValue && IdLabel.Text != value.Value.ToString())
                {
                   IdLabel.Text = value.ToString();
                }
            }
        }

        public Panel DataModelInfo
        {
            get
            {
                return DataModelInfo;
            }            
        }

        public Panel DataModelsInfo
        {
            get
            {
                return SelectDataModelPanel;
            }
        }

        #endregion

        #region Private properties

        private DataModelPresenter dataModelPresenter;

        private BindingSource dataItemsSource;
        
        private bool IsEditMode;

        #endregion

        #region Constructor

        public DataModelUserControl()
        {
            InitializeComponent();            
            dataModelPresenter = new DataModelPresenter(this);

            SetDefaultConfig();
        }

        #endregion

        #region Methods

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

        public void FillDataModelNames()
        {
            DataModels = new ComboBox();
            dataModelPresenter.LoadDataModels();
        }

        #endregion

        #region Events

        private void DataModelPanel_Paint(object sender, PaintEventArgs e)
        {
            DataModelNameTextBox.Text = "";
            DataModelNameTextBox.Focus();
        }

        private void AddDataItemButton_Click(object sender, EventArgs e)
        {
            dataModelPresenter.AddItemToList();
            dataItemsSource.ResetBindings(false);

            Item = "";
            DataItemTextBox.Focus();
        }

        private void RemoveNewDataItemButton_Click(object sender, EventArgs e)
        {
            dataModelPresenter.RemoveItemFromList();
            dataItemsSource.ResetBindings(true);
        }

        private void CreateNewDataModelRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(CreateDataModelRadioButton.Checked)
            {
                SelectDataModelPanel.Hide();
                DataModelInfoGroupBox.Show();

                EditionModeLabel.Visible = false;
                DeleteDataModelButton.Hide();

                dataModelPresenter.ClearAll();

                IsEditMode = true;
            }
        }

        private void UpdateDataModelRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (UpdateDataModelRadioButton.Checked)
            {
                SelectDataModelPanel.Show();
                DataModelInfoGroupBox.Hide();
                
                DeleteDataModelButton.Show();

                dataModelPresenter.ClearAll();
                dataModelPresenter.LoadDataModels();               
            }
        }

        private void SaveDataModelButton_Click(object sender, EventArgs e)
        {
            if(IsEditMode)
            {
                dataModelPresenter.UpdateDataModel(Id ?? -1);
            }
            else
            {
                dataModelPresenter.CommitNew();
            }
        }
        
        private void ManageableDataModelsComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            var id = int.Parse(cmb.SelectedValue.ToString());

            if (dataModelPresenter.FindDataModel(id))
            {
                IsEditMode = true;

                EditionModeLabel.Visible = true;
                DataModelInfoGroupBox.Show();
            }
        }

        private void DeleteDataModelButton_Click(object sender, EventArgs e)
        {
            ComboBox cmb = DataModels;

            if(cmb.SelectedValue != null)
            {
                var id = int.Parse(cmb.SelectedValue.ToString());

                if (MessageBox.Show("Certeza de que deseja deletar este modelo de dados? Não é possível desfazer essa ação", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    dataModelPresenter.DeleteDataModel(id);
                }
            }
            else
            {
                MessageBox.Show("Nenhum modelo de dados selecionado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;
            }
        }        

        #endregion

    }
}
