using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_IComparable
{
    internal class SortFrequency : IComparer<Headphones>
    {
        public int Compare(Headphones? x, Headphones? y)
        {
            return x.Frequency.CompareTo(y.Frequency);
        }


    }
}
