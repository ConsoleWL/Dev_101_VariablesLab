namespace Loops_Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("Hello");
            }

            for (int i = 0; i <=10; i++)
            {
                Console.WriteLine(i);
            }

            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine(i);
            }

            int userInput;
            Console.WriteLine("Enter number of loops");
            userInput = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < userInput; i++)
            {
                Console.WriteLine("devCodeCamp");
            }

            string team = "Packers";
            foreach (char letter in team)
            {
                Console.WriteLine(letter);
            }


        }
    }
}