using GeraContrato.Views.DataModel;
using GeraContrato.Entities;

namespace GeraContrato.Presenters
{
    class DataModelPresenter
    {
        IDataModel dataModelView;
        DataModel dataModel;

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
        }

        public void CommitNew()
        {
            BeforeCommitNew();
            dataModel.NewDataModel();
        }
    }
}
