using System;
using PHydrate.Attributes;

namespace AdventureWorksLib
{
    public class ProductCategory : PropertyStringOutput
    {
        [PrimaryKey]
        public int ProductCategoryId { get; set; }

        public ProductCategory ParentProductCategory { get; set; }

        public string Name { get; set; }

        public Guid Rowguid { get; set; }

        public DateTime ModifiedDate { get; set; }
    }
}