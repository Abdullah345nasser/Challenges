namespace CarpetChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
           const int  periceOfSmallRoom = 25;
            const int periceOfLargeRoom = 35;
            const float salesTaxRate = 0.06f;

            Console.Write("Number of small rooms: ");

            int numberOfSmallRooms= int.Parse(Console.ReadLine());

            Console.Write("Number of Large rooms: ");

            int numberOfLargeRooms= int.Parse(Console.ReadLine());

            Console.WriteLine("Price per small room: $" + periceOfSmallRoom);

            Console.WriteLine("Price per large room: $" + periceOfLargeRoom);

            float costOfSmall = periceOfSmallRoom * numberOfSmallRooms;

            float costOfLarge = periceOfLargeRoom * numberOfLargeRooms;

            float cost = costOfSmall + costOfLarge;

            Console.WriteLine("Cost : $"+cost);
            float Tax = cost * salesTaxRate;
            Console.WriteLine("Tax: $"+Tax);
            Console.WriteLine("================================");
            Console.WriteLine("Total estimate: $" + (cost + Tax));
            int estimateDays = 30;
            Console.WriteLine($"This estimate is valid for{ estimateDays} days");
        }
    }
}
