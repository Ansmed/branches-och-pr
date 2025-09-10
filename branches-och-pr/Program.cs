namespace branches_och_pr
{
    internal class Program
    {
        static void Main(string[] args)

        {
            int input = -1;
            while (input != 0)
            {
                Console.WriteLine("Skriv in ett nummer för att se om det är jämnt (0 för att avsluta): ");
                input = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(isEven(input));
            }
        }
        public static bool isEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
