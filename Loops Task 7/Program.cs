namespace Loops_Task_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = 1;

            while (counter < 6)
            {
                Console.WriteLine("Hello");
                counter++;
            }

            

            while (true)
            {
                Console.WriteLine("Enter the password");
                string password = Console.ReadLine();

                if (password == "12345")
                {
                    Console.WriteLine("User Vallidated");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid password");
                }
            }

            


        }
    }
}