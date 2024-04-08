namespace MyProgram
{
        class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0, result = 0;
            string userInput;

            Console.WriteLine("Enter a number");
            userInput = Console.ReadLine(); // Remember Readline returns a string, so we have to convert to an integer.
            a = int.Parse(userInput); // Using TryParse() instead could avoid throwing exceptions
         
            Console.WriteLine("Enter a another number");
            userInput = Console.ReadLine();
            b = Int32.Parse(userInput); // Same as int.Parse()

            
            try
            {
                result = ExceptionHandling.Division(a, b);
                Console.WriteLine(result);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            

            

            Console.WriteLine("End of Program");
        }
    }
}