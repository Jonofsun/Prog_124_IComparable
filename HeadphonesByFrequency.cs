using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_IComparable
{
    internal class HeadphonesByFrequency : IComparable<HeadphonesByFrequency>
    {
        public string Brand { get; set; }
        public int Frequency { get; set; }

        public HeadphonesByFrequency(string brand, int frequency)
        {
            Brand = brand;
            Frequency = frequency;
        }

        public int CompareTo(HeadphonesByFrequency other)
        {
            return Frequency.CompareTo(other.Frequency);
        }
    }
}
