using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_IComparable
{
    internal class Headphones : IComparable<Headphones>
    {
        string _brand;
        int _frequency;
        double _price;

        public Headphones(string brand, int frequency, double price)
        {
            _brand = brand;
            _frequency = frequency;
            _price = price;
        }

        public string Brand { get => _brand; set => _brand = value; }
        public int Frequency { get => _frequency; set => _frequency = value; }
        public double Price { get => _price; }
        public void BigSale(double price)
        {
            _price = price / 2;
        }

        public int CompareTo(Headphones? other)
        {
            return Brand.CompareTo(other.Brand);
        }

        public override string ToString()
        {
            return $"Brand: {_brand} Frequency: {_frequency} Price: {_price}";
        }
    }
}
