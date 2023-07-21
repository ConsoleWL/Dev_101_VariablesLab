namespace Variables_Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 32;
            Console.WriteLine($"I am {age} years old");

            string firstName;

            Console.WriteLine("Enter your first name, please:");
            firstName = Console.ReadLine();

            string lastName;
            Console.WriteLine("Enter your last name, please");
            lastName = Console.ReadLine();

            Console.WriteLine($"My first name is {firstName} and my last name {lastName}, which means my full name is {firstName} {lastName}");

        }
    }
}