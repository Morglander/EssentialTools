using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EssentialTools.Models
{
    public class LinqValueCalculator : IValueCalculator
    {
        private IDiscountHelper discounter;

        public LinqValueCalculator(IDiscountHelper discountParam)
        {
            discounter = discountParam;
        }

        public decimal ValueProducts(IEnumerable<Product> product)
        {
            return discounter.ApplyDiscount(product.Sum(p => p.Price));
        }
    }
}