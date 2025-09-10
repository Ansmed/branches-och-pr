namespace branches_och_pr
{
    internal class Program
    {
        static void Main(string[] args)

        {
            
            while (input != 0)
            {
                Console.WriteLine("Skriv in ett nummer för att se om det är jämnt (0 för att avsluta): ");
                int input = Convert.ToInt32(Console.ReadLine());
            }
        }
        public bool isEven(int number)
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
