namespace Prog_124_IComparable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Headphones> headphonesList = new List<Headphones>();

            // Add at least 5 items to the list
            headphonesList.Add(new Headphones("Brand 1", "Style 1", "Model 1", "Transmission 1", 100));
            headphonesList.Add(new Headphones("Brand 2", "Style 2", "Model 2", "Transmission 2", 200));
            headphonesList.Add(new Headphones("Brand 3", "Style 3", "Model 3", "Transmission 3", 300));
            headphonesList.Add(new Headphones("Brand 4", "Style 4", "Model 4", "Transmission 4", 400));
            headphonesList.Add(new Headphones("Brand 5", "Style 5", "Model 5", "Transmission 5", 500));

            Console.WriteLine("Displaying list without sorting:");
            DisplayList(headphonesList);

            Console.WriteLine("\nDisplaying list sorted:");
            headphonesList.Sort();
            DisplayList(headphonesList);

            Console.WriteLine("\nDisplaying list sorted by Frequency:");
            List<HeadphonesByFrequency> sortedByFrequency = new List<HeadphonesByFrequency>();
            foreach (var headphones in headphonesList)
            {
                sortedByFrequency.Add(new HeadphonesByFrequency(headphones.Brand, headphones.Frequency));
            }
            sortedByFrequency.Sort();
            DisplayList(sortedByFrequency);

            Console.WriteLine("\nDisplaying list sorted by Price:");
            List<eadphonesByPrice> sortedByPrice = new List<eadphonesByPrice>();
            foreach (var headphones in headphonesList)
            {
                sortedByPrice.Add(new eadphonesByPrice(headphones.Brand, headphones.Price));
            }
            sortedByPrice.Sort();
            DisplayList(sortedByPrice);
        }

        static void DisplayList<T>(List<T> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}