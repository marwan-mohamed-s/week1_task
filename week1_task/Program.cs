namespace W1_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Small_Carpet = 0, Large_Carpet = 0, Cost = 0;
            double Tax = 0, Total_Cost = 0;
            Console.WriteLine("welcome to islam clean carpet \n\"$25\" => per small carpet\n\"$35\" => per large carpet \nnote: Sales tax rate is \"6%\"");
            Console.WriteLine("======================");
            Console.WriteLine("inter your small carpets :");
            Small_Carpet = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("inter your large carpets :");
            Large_Carpet = Convert.ToInt32(Console.ReadLine());
            Cost = (Small_Carpet * 25) + (Large_Carpet * 35);
            Tax = 6.00 / 100 * Cost;
            Total_Cost = Cost + Tax;
            Console.WriteLine("======================");
            Console.WriteLine($"Total estmate : {Total_Cost}\nTax : {Tax}\nthis estimate is valid for 30 days");
        }
    }
}