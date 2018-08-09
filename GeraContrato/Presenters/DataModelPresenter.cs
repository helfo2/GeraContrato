using GeraContrato.Views.DataModel;
using GeraContrato.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data;

namespace GeraContrato.Presenters
{
    class DataModelPresenter
    {
        IDataModel dataModelView;
        DataModel dataModel;
        List<DataModelItem> dataModelItems; 

        public DataModelPresenter(IDataModel view)
        {
            this.dataModelView = view;

            dataModel = new DataModel();
            dataModelItems = new List<DataModelItem>();
        }

        public void AddItemToList()
        {
            if (!string.IsNullOrWhiteSpace(dataModelView.Item))
            {
                dataModelView.DataItems.Items.Add(dataModelView.Item);
            }
        }

        public void RemoveItemFromList()
        {
            dataModelView.DataItems.Items.Remove(dataModelView.SelectedNewItem);            
        }

        private bool BeforeCommitNew()
        {
            dataModel = new DataModel
            {
                Id = null,
                Name = dataModelView.Name
            };

            if(dataModel.FindAll().FirstOrDefault(x => x.Name == dataModelView.Name) != null)
            {
                MessageBox.Show("Já existe um modelo de dados com esse nome!", "Nome inválido", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return false;
            }
            else
            {
                return true;
            }
        }

        public void CommitNew()
        {
            if(BeforeCommitNew())
            {
                dataModel.NewDataModel();
                AfterCommitNew();
            }
        }

        private void AfterCommitNew()
        {
            if(dataModelView.DataItems.Items.Count != 0)
            {
                List<string> newItems = dataModelView.DataItems.Items.Cast<String>().ToList();

                foreach (var item in newItems)
                {
                    dataModelItems.Add(new DataModelItem { Id = null, Name = item, CurrentDataModel = dataModel });
                }

                int id = GetNewDataModelId() ?? default(int);
                dataModelItems.ForEach(i => i.SetDTO());
                dataModelItems.ForEach(i => i.DataModelItemEntity.DataModel = dataModel.Convert_DataModelToDTO(new DataModel { Id = id }));
                dataModelItems.ForEach(i => i.NewDataModelItem(i.GetDTO()));

                MessageBox.Show("Modelo de dados cadastrado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                AfterAddDataModel();
            }
            else
            {
                MessageBox.Show("Sem itens neste modelo de dados", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        public void LoadDataModels()
        {
            dataModelView.DataModels.DisplayMember = "name";
            dataModelView.DataModels.ValueMember = "id";

            dataModelView.DataModels.DataSource = dataModel.LoadDataModels();
        }

        public bool FindDataModel(int id)
        {
            Tuple<int?, string> t = new Tuple<int?, string>(-1, "");
            t = dataModel.Find(id);

            if(t.Item1 == -1)
            {
                MessageBox.Show("Modelo de dados não encontrado!", "Erro do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return false;
            }
            else
            {
                dataModelView.Id = t.Item1;
                dataModelView.Name = t.Item2;

                dataModelView.DataItems.Items.Clear();
                foreach (var item in GetDataItems())
                {
                    dataModelView.DataItems.Items.Add(item);
                }

                return true;
            }
        }

        public List<string> GetDataItems()
        {
            List<string> dataItems = new List<string>(dataModel.SelectDataItems().Select(i => i.Name));
            return dataItems;
        }

        public int? GetNewDataModelId()
        {
            return dataModel.GetNew().Id;
        }

        private void AfterAddDataModel()
        {
            dataModelView.DataItems.Items.Clear();
            dataModelView.Name = "";
            dataModelView.Item = "";
            
            LoadDataModels();
        }

        public void DeleteDataModel(int id)
        {
            dataModel.SetEntityDTO(id);
            dataModel.Delete();

            MessageBox.Show("Modelo de dados deletado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

            ClearAll();

            LoadDataModels();
        }

        public void UpdateDataModel(int id)
        {
            if(id != -1)
            {                
                dataModel.DataModelEntity.Id = id;
                dataModel.DataModelEntity.Name = dataModelView.Name;

                dataModel.Update(dataModelView.DataItems.Items.Cast<String>().ToList());

                LoadDataModels();
            }
            else
            {
                MessageBox.Show("Algo na atualização deu errado!", "Erro de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        public void ClearAll()
        {
            dataModelView.DataModels.SelectedItem = "";
            if(dataModelView.DataModels.Text != "Selecione...")
                dataModelView.DataModels.Text = "Selecione...";

            dataModelView.Id = -1;
            dataModelView.Item = "";
            dataModelView.Name = "";
            dataModelView.DataItems.Items.Clear();            
        }
    }
}
