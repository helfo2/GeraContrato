using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeraContrato.Views.DataModel
{
    public interface IDataModel
    {
        string Name { get; set; }

        string Item { get; set; }

        string SelectedNewItem { get; }
        
        ListBox DataItems { get; }

        ComboBox DataModels { get; set; }

        int? Id { get; set; }

        Panel DataModelInfo { get; }

        Panel DataModelsInfo { get; }
    }
}
