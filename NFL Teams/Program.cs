namespace NFL_Teams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nflTeam;
            Console.WriteLine("Enter your favourite NFL team");
            nflTeam = Console.ReadLine();

            switch (nflTeam)
            {
                case "Bears":
                    Console.WriteLine("Blue and Orange");
                    break;
                case "Vikings":
                    Console.WriteLine("Purple and Yellow");
                    break;
                case "Lions":
                    Console.WriteLine("Blue or Grey");
                    break;
                case "Packers":
                    Console.WriteLine("Green and Gold");
                    break;
                default:
                    Console.WriteLine("Pick a different team");
                    break;
            }
        }
    }
}