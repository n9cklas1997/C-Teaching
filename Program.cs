namespace MyProgram
{
        class Program
    {
        static void Main()
        {
            AccessModifier user1 = new AccessModifier("Lars", "123", 169);

            Console.WriteLine(user1.Username); // Only username can be accessed 

            user1.Login("123");
            Console.WriteLine(user1.GetIsAuthenticated());

            Console.ReadKey();
        }
    }
}