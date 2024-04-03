namespace MyProgram
{
        class Property
    { 
        // Like you can use the private keyword to prevent outside access, you can instead use propeties.
        // Properties gives more control to the developer. 
        // For example, we can make a variable read-only in other classes. This is done by only have a "getter" (get accessor).
        // Likewise a write-only is with only a "setter" (set accessor).
        // With a property, we can also validate if input is of correct structure before we assign some value.
        // Since we might want to control a variable more in the future, we just make properties rather than public fields.
        

        // Example of a public field and then a property (Currently the same, since we haven't done anything with get and set)
        public string? FirstName; // Bad
        public string? LastName {get; set;} // Good

        // If we start with a public field and later need to add validation logic or change the internal representation, 
        // we will need to change every place where the field is accessed. 
        // Using properties from the start simplifies future refactoring.


        // Next example of a property were we validate that age is between 0 and 110
        // NOTE: naming convention - I use _ prefix for private fields.
        private int _Age = 10; // we initialize to 10 to see that the value is still 10, when trying to change Age to a value out of range.
        public int Age 
        {
            get
            {
                return _Age;
            } 
            set
            {
                if(value >= 0 && value <= 110)
                {
                    _Age = value;
                }
            }
        }
    }

    /* ----- Program.cs testing -----
        Property user2 = new Property();
        user2.Age = 111;
        Console.WriteLine(user2.Age);
    */
}