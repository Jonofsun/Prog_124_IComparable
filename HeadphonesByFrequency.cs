using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_IComparable
{
    internal class HeadphonesByFrequency : IComparable<HeadphonesByFrequency>
    {
        
        public int Frequency { get; set; }

        public HeadphonesByFrequency(int frequency)
        {
            
            Frequency = frequency;
        }

        public int CompareTo(HeadphonesByFrequency other)
        {
            return other.Frequency.CompareTo(Frequency);
        }
    }
}
