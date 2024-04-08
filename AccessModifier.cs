namespace MyProgram
{
    public class AccessModifier
    {

        // When declaring a member, you specify the access modifier of that member. (private by default)
        // This can be 6 different: public, private, protected, internal, protected internal & private protected.
        // The access modifier describes the level of encapsulation - If other classes and components can write or read the data.
        // A member can be a variable/method/property - We also call a variable member for a field.
        // Fields (meaning not a property), should not be public or protected for better encapsulation.
        

        public string Username;           // public field             - Every class can access this data.

        private string _Password;         // private field            - Only this class can access this data.

        protected int IQ;                 // protected field          - This class and subclasses can access this data.

        internal int Rating;              // internal field           - This assembly

        protected internal int Rating2;   // protected internal field - This assembly OR this class and subclasses.

        private protected int Rating3;    // private protected field  - This is a private protected field.
                                          // This class or subclasses within the same assembly.
     

        // What is an assembly? - It could be a DLL file or an executable (EXE) file that contains your classes, methods, 
        // and other program elements, along with metadata. This assembly encompasses all the compiled code, resources, 
        // and metadata needed for your application to run. 
        // Depending on your development environment and settings, this assembly might be generated when you build your project.
        // The assembly in this case is CS-Teaching.dll and CS-Teaching.exe, which are found in bin\debug\net8.0
        // The reason it is found in a debugging folder, is because the default configuration is debug.


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