using AdventureWorksLib;
using PHydrate;

namespace PHydrateSpecificationDemo
{
    public class CombinedSpecification : ProductNameSpecification, IExplicitSpecification<Product>
    {
        private readonly string _color;

        public CombinedSpecification(string productName, string color) : base(productName)
        {
            _color = color;
        }

        #region Implementation of IExplicitSpecification<Product>

        public bool Satisfies(Product obj)
        {
            return obj.Color == _color;
        }

        #endregion
    }
}