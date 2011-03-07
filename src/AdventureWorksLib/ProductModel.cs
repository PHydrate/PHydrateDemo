using System;
using PHydrate.Attributes;

namespace AdventureWorksLib
{
    public class ProductModel : PropertyStringOutput
    {
        [PrimaryKey]
        private int ProductModelId { get; set; }

        public string Name { get; private set; }

        public string CatalogDescription { get; private set; }

        public Guid Rowguid { get; set; }

        public DateTime ModifiedDate { get; private set; }
    }
}