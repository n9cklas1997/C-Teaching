namespace MyProgram
{
        class Program
    {
        static void Main(string[] args)
        {
            AccessModifier user1 = new AccessModifier("Lars", "123", 169);

            Console.WriteLine(user1.Username); // Only username can be accessed 

            user1.Login("123");
            Console.WriteLine(user1.GetIsAuthenticated());


            Property user2 = new Property();
            user2.Age = 111;
            Console.WriteLine(user2.Age);


            // Command-line arguments for example: dotnet run 666 420
            // NOTE: In C, the first element argv[0] contained the name of the program.
            // Here args[0] is the first command-line argument, which would be argv[1] in C.
            Console.WriteLine("First argument is: " + args[0]);
            Console.WriteLine("Second argument is: " + args[1]);

            Console.ReadKey();
        }
    }
}