using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeraContrato.Models
{
    public class DataModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<string> FieldNames { get; set; }        
    }
}
