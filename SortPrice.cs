using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_IComparable
{
    internal class SortPrice : IComparer<Headphones>
    {
        public int Compare(Headphones? x, Headphones? y)
        {
            return x.Price.CompareTo(y.Price);
        }

    }
}
