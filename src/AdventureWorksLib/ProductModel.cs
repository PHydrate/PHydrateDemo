using System;
using PHydrate.Attributes;

namespace AdventureWorksLib
{
    public class ProductModel : PropertyStringOutput
    {
        [PrimaryKey]
        public int ProductModelId { get; set; }

        public string Name { get; set; }

        public string CatalogDescription { get; set; }

        public Guid Rowguid { get; set; }

        public DateTime ModifiedDate { get; set; }
    }
}