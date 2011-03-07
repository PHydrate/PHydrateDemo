using System;
using System.Linq.Expressions;
using AdventureWorksLib;
using PHydrate;

namespace PHydrateSpecificationDemo
{
    public class ProductNameSpecification : IDbSpecification<Product>
    {
        private readonly string _productName;

        public ProductNameSpecification(string productName)
        {
            _productName = productName;
        }

        #region Implementation of IDbSpecification<Product>

        public Expression<Func<Product, bool>> Criteria
        {
            get { return x => x.Name == _productName; }
        }

        #endregion
    }
}