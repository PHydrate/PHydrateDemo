using System;
using System.Linq.Expressions;
using AdventureWorksLib;
using PHydrate;

namespace PHydrateSpecificationDemo
{
    public class ProductNumberSpecification : IDbSpecification<Product>
    {
        private readonly string _productNumber;

        public ProductNumberSpecification(string productNumber)
        {
            _productNumber = productNumber;
        }

        #region Implementation of IDbSpecification<Product>

        public Expression<Func<Product, bool>> Criteria
        {
            get { return x => x.ProductNumber == _productNumber; }
        }

        #endregion
    }
}