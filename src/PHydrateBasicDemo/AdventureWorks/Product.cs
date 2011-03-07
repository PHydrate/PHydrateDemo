using System;
using PHydrate.Attributes;

namespace PHydrateDemo.AdventureWorks
{
    [HydrateUsing("GetProduct")]
    //[AggregateRoot]
    public class Product
    {
        [PrimaryKey]
        public int ProductId { get; set; }

        public string Name { get; set; }

        public string ProductNumber { get; set; }

        public string Color { get; set; }

        public decimal StandardCost { get; set; }

        public decimal ListPrice { get; set; }

        public string Size { get; set; }

        public decimal? Weight { get; set; }

        [Recordset(1)]
        public ProductCategory ProductCategory { get; set; }

        [Recordset(2)]
        public ProductModel ProductModel { get; set; }

        public DateTime SellStartDate { get; set; }

        public DateTime? SellEndDate { get; set; }

        public DateTime? DiscontinuedDate { get; set; }

        // public Stream ThumbNailPhoto {get ;set; }

        public string ThumbnailPhotoFileName { get; set; }

        public Guid Rowguid { get; set; }

        public DateTime ModifiedDate { get; set; }
    }
}