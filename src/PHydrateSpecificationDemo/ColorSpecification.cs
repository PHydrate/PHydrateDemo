using AdventureWorksLib;
using PHydrate;

namespace PHydrateSpecificationDemo
{
    public class ColorSpecification : IExplicitSpecification<Product>
    {
        private readonly string _color;

        public ColorSpecification(string color)
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