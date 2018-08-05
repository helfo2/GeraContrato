using GeraContrato.Views.ContractModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeraContrato.Presenters
{
    class ContractModelPresenter
    {
        IContractModel contractModelView;

        public ContractModelPresenter(IContractModel view)
        {
            this.contractModelView = view;
        }

        public void FindBlanks()
        {
            var text = contractModelView.ContractText;
            List<int> blanks = new List<int>();

            for(int i = 0; i < text.Length; i++)
            {
                if (text[i] == '_')
                {
                    blanks.Add(i);
                }
            }
        }
    }
}
