namespace MyProgram
{
    public static class ExceptionHandling
    {
        public static int Division(int x, int y)
        {
            // Division by 0 would cause an error at run time.
            // It is not really an error in the code - but rather a special case.
            // This is what we instead call an exception.
            // This case whould then be a divide-by-zero exception.
            return x / y;
        }
    }
            // Developers should avoid throwing exceptions for something expected or normal control flow.
            // For example, we should not expect a user to input something valid.
            // Instead we could check if the dividend is 0 before we execute the Method. (Since we here rely on userinput)
            // (if y != 0)...

    /* ----- Program.cs testing -----
            int a = 0, b = 0, result = 0;
            string userInput;

            Console.WriteLine("Enter a number");
            userInput = Console.ReadLine(); // Remember Readline returns a string, so we have to convert to an integer.
            a = int.Parse(userInput); // Using TryParse() instead could avoid throwing exceptions
         
            Console.WriteLine("Enter a another number");
            userInput = Console.ReadLine();
            b = Int32.Parse(userInput); // Same as int.Parse()

            result = ExceptionHandling.Division(a, b);

            Console.WriteLine(result);

            Console.WriteLine("End of Program");
    */
    /*
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
    */
}