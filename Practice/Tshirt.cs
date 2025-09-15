using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Tshirt
    {
        public double Price { get; set; }
        public double Discount { get; set; }

        public virtual double DiscountedPrice
        {
            get { return Price - DiscountedPrice; }
        }
    }

    class Sando : Tshirt
    {
        public override double DiscountedPrice
        {
            get { return Price - Discount; }
        }
    }
    class Polo : Tshirt
    {
        public override double DiscountedPrice
        {
            get { return Price - Discount; }
        }
    }
    class Croptop : Tshirt
    {
        public override double DiscountedPrice
        {
            get { return Price - Discount; }
        }
    }
}