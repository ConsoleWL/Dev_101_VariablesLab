namespace Random_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int randomNumber;

            Random rnd = new Random();
            randomNumber = rnd.Next(11);

            if (randomNumber <= 2)
            {
                Console.WriteLine("0 or 1 or 2");
            }
            else if( randomNumber >=3 && randomNumber <= 5)
            {
                Console.WriteLine("3 or 4 or 5");
            }
            else if(randomNumber >=6 && randomNumber <=8)
            {
                Console.WriteLine("6 ir 7 or 8");
            }
            else
            {
                Console.WriteLine("9 or 10");
            }
        }
    }
}