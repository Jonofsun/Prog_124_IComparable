namespace Prog_124_IComparable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Headphones> headphonesList = new List<Headphones>();

            // Add at least 5 items to the list
            headphonesList.Add(new Headphones("Brand 1", 20000, 100));
            headphonesList.Add(new Headphones("Brand 2", 40000, 200));
            headphonesList.Add(new Headphones("Brand 3", 37000, 300));
            headphonesList.Add(new Headphones("Brand 4", 9000, 400));
            headphonesList.Add(new Headphones("Brand 5", 68000, 500));

            Console.WriteLine("Displaying list without sorting:");
            DisplayList(headphonesList);

            Console.WriteLine("\nDisplaying list sorted:");
            headphonesList.Sort();
            DisplayList(headphonesList);

            Console.WriteLine("\nDisplaying list sorted by Price:");
            SortPrice sp = new SortPrice();
            headphonesList.Sort(sp);     
            DisplayList(headphonesList);

            Console.WriteLine("\nDisplaying list sorted by Frequency:");
            SortFrequency sf = new SortFrequency();
            headphonesList.Sort(sf);
            DisplayList(headphonesList);

            
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