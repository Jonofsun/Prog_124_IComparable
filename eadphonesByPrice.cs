using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_IComparable
{
    internal class eadphonesByPrice : IComparable<eadphonesByPrice>
    {
        
        public double Price { get; set; }

        public eadphonesByPrice(double price)
        {
            
            Price = price;
        }

        public int CompareTo(eadphonesByPrice other)
        {
            return other.Price.CompareTo(Price); // Sort in descending order
        }
    }
}
// if > return 1
// else if < return -1
// else 0