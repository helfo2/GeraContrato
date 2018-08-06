using GeraContrato.Views.DataModel;
using GeraContrato.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using GeraContrato.Models.DataModelItem;
using System.Windows.Forms;
using GeraContrato.Helpers.Exceptions;

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
            if (!string.IsNullOrWhiteSpace(dataModelView.Item))
            {
                dataModelView.DataItems.Items.Remove(dataModelView.NewSelectedItem);
            }
        }

        private void BeforeCommitNew()
        {
            dataModel = new DataModel
            {
                Id = null,
                Name = dataModelView.Name
            };

            try
            {
                if(dataModel.FindAll().FirstOrDefault(x => x.Name == dataModelView.Name) != null)
                {

                }
            }
            catch(ExistingEntityException)
            {
                MessageBox.Show("Já existe um modelo de dados com esse nome!");
            }
        }

        public void CommitNew()
        {
            BeforeCommitNew();
            dataModel.NewDataModel();
            AfterCommitNew();
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

                dataModelItems.ForEach(i => i.SetDTO());
                dataModelItems.ForEach(i => i.NewDataModelItem(i.GetDTO()));
            }
            else
            {
                MessageBox.Show("Sem itens neste modelo de dados!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            
        }
    }
}
