using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeraContrato.Views.ContractModel
{
    interface IContractModel
    {
        string ContractText { get; set; }

        List<int> BlankPositions { get; set; }
    }
}
