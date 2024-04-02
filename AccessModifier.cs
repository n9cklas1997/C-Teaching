namespace MyProgram
{
    class AccessModifier
    {

        // When declaring a member, you specify the access modifier of that member. (private by default)
        // This can be 5 different: public, private, protected, internal and protected internal.
        // The access modifier describes the level of encapsulation - If other classes and components can write or read the data.
        // A member can be a variable/method/property.
        

        public string username;  // public variable    - Every class can access this data.

        private string password; // private variable   - Only this class can access this data.

        protected int IQ;        // protected variable - This class and subclasses can access this data.

        // We will look at internal later



        // Making two methods that can be accessed in other classes that checks if a password is correct.
        // This way the data of password cannot be changed or viewed.
        // However, it is still possible to call these methods in other classes to check if a password is correct.
        private bool isAuthenticated;
        public bool Login(string aPassword)
        {
            if(password == aPassword)
            {
                isAuthenticated = true;
            }
            return isAuthenticated;
        }

        public bool GetIsAuthenticated()
        {
            return isAuthenticated;
        }


        // Constructor
        public AccessModifier(string aUsername, string aPassword, int aIQ)
        {
            username = aUsername;
            password = aPassword;
            IQ       = aIQ;
        }

    }
}