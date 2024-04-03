namespace MyProgram
{
    class AccessModifier
    {

        // When declaring a member, you specify the access modifier of that member. (private by default)
        // This can be 5 different: public, private, protected, internal and protected internal.
        // The access modifier describes the level of encapsulation - If other classes and components can write or read the data.
        // A member can be a variable/method/property - We also call a variable member for a field.
        // Fields (meaning not a property), should not be public or protected for better encapsulation.
        

        public string Username;   // public field       - Every class can access this data.

        private string _Password; // private field      - Only this class can access this data.

        protected int IQ;         // protected field    - This class and subclasses can access this data.

        // We will look at internal later



        // Making two methods that can be accessed in other classes that checks if a password is correct.
        // This way the data of password cannot be changed or viewed.
        // However, it is still possible to call these methods in other classes to check if a password is correct.
        private bool _IsAuthenticated;
       
        public bool Login(string password)
        {
            if(_Password == password)
            {
                _IsAuthenticated = true;
            }
            return _IsAuthenticated;
        }

        public bool GetIsAuthenticated()
        {
            return _IsAuthenticated;
        }


        // Constructor
        public AccessModifier(string username, string password, int iQ)
        {
            Username  = username;
            _Password = password;
            IQ        = iQ;
        }
    }

    /* ----- Program.cs testing -----
        AccessModifier user1 = new AccessModifier("Lars", "123", 169);

        Console.WriteLine(user1.Username); // Only username can be accessed 

        user1.Login("123");
        Console.WriteLine(user1.GetIsAuthenticated());
    */
}