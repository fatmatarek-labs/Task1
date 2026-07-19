namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Estimate for carpet cleaning service");
            Console.WriteLine("Number of small carpets:");
            int small = Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine("Number of large carpets:");
            int large = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Price per small carpet : $25");
            Console.WriteLine("Price per large carpet : $35");
            int cost = (small*25) + (large*35);
            double tax = (0.06 * cost);
            Console.WriteLine($"Cost = ${cost}");
            Console.WriteLine($"Tax = ${tax}");
            Console.WriteLine("=======================================");
            double tot = cost + tax;
            Console.WriteLine($"Total Estimate = ${tot}");
            Console.WriteLine("This estimate is valid for 30 days");


        }
    }
}
