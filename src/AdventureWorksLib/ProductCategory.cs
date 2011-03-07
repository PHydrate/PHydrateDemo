using System;
using PHydrate.Attributes;

namespace AdventureWorksLib
{
    public class ProductCategory : PropertyStringOutput
    {
        [PrimaryKey]
        private int ProductCategoryId { get; set; }

        public ProductCategory ParentProductCategory { get; private set; }

        public string Name { get; private set; }

        public Guid Rowguid { get; private set; }

        public DateTime ModifiedDate { get; private set; }
    }
}