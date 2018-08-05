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
        string Item { get; set; }

        string NewSelectedItem { get; }        
        
        ListBox DataItems { get; }
    }
}
