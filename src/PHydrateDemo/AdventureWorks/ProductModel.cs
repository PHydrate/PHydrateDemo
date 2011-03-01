using System;
using PHydrate.Attributes;

namespace PHydrateDemo.AdventureWorks
{
    public class ProductModel
    {
        [PrimaryKey]
        public int ProductModeId { get; set; }

        public string Name { get; set; }

        public string CatalogDescription { get; set; }

        public Guid Rowguid { get; set; }

        public DateTime ModifiedDate { get; set; }
    }
}