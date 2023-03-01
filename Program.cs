namespace RegexProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Regex Problem");
            RegexProblem regex = new RegexProblem();
            regex.ValidateFirstName("Ajay");
            regex.ValidateLastName("Rathod");
            Console.ReadLine();
        }
    }
}