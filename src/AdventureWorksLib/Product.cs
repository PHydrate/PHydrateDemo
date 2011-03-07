using System;
using PHydrate.Attributes;

namespace AdventureWorksLib
{
    [HydrateUsing("GetProduct")]
    //[AggregateRoot]
    public class Product : PropertyStringOutput
    {
        [PrimaryKey]
        private int ProductId { get; set; }

        public string Name { get; private set; }

        public string ProductNumber { get; private set; }

        public string Color { get; private set; }

        public decimal StandardCost { get; private set; }

        public decimal ListPrice { get; private set; }

        public string Size { get; private set; }

        public decimal? Weight { get; private set; }

        [Recordset(1)]
        public ProductCategory ProductCategory { get; private set; }

        [Recordset(2)]
        public ProductModel ProductModel { get; private set; }

        public DateTime SellStartDate { get; private set; }

        public DateTime? SellEndDate { get; private set; }

        public DateTime? DiscontinuedDate { get; private set; }

        // public Stream ThumbNailPhoto {get ;set; }

        public string ThumbnailPhotoFileName { get; private set; }

        public Guid Rowguid { get; private set; }

        public DateTime ModifiedDate { get; private set; }
    }
}