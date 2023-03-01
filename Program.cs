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
            regex.ValidateEmail("abc.xyz@bl.co.in");
            regex.ValidatePhoneNumber("91 9896271453");
            Console.ReadLine();
        }
    }
}