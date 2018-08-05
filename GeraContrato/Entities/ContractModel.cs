using System.Collections.Generic;

namespace GeraContrato.Entities
{
    class ContractModel
    {
        /// <summary>
        /// The actual text of the contract.
        /// </summary>
        public string ContractText { get; set; }

        /// <summary>
        /// The indexes to be replaced with important custom data.
        /// </summary>
        public List<int> BlankPositions { get; set; }        
    }
}
