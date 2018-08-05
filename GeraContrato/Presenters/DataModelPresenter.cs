using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeraContrato.Views.DataModel;
using GeraContrato.Models;

namespace GeraContrato.Presenters
{
    class DataModelPresenter
    {
        IDataModel dataModelView;

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
    }
}
