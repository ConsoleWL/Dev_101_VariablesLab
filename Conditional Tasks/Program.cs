namespace Conditional_Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int drivingLegalAge = 18;
            int userAge;

            Console.WriteLine("Enter your age:");
            userAge = Convert.ToInt32(Console.ReadLine());

            if (userAge >= drivingLegalAge)
            {
                Console.WriteLine("You are legally able to drive");
            }
            else
            {
                Console.WriteLine("You are not old enough to drive yet");
            }

        }
    }
}