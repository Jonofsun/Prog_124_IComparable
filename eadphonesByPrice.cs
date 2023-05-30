using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_IComparable
{
    internal class eadphonesByPrice : IComparable<eadphonesByPrice>
    {
        public string Brand { get; set; }
        public double Price { get; set; }

        public eadphonesByPrice(string brand, double price)
        {
            Brand = brand;
            Price = price;
        }

        public int CompareTo(eadphonesByPrice other)
        {
            return other.Price.CompareTo(Price); // Sort in descending order
        }
    }
}
