using GeraContrato.Models.DataModel;

namespace GeraContrato.Models.DataModelItem
{
    public class DataModelItemDTO
    {
        public int? Id { get; set; }

        public string Name { get; set; }

        public DataModelDTO DataModel { get; set; }
    }
}
