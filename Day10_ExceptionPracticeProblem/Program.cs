namespace Day10_ExceptionPracticeProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a person's age:");
            string age = Console.ReadLine();

            PersonAge.PersonAgeAbility(age);
            Console.ReadLine();
        }
    }
}