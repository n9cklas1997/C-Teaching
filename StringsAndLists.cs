namespace MyProgram
{
    public class StringsAndLists
    {
        public void JustAnotherStringMethod()
        {
            // Allocate space on stack for a string
            string str = "Hello Frederik";

            // Print the string, then print the element at index 1.
            Console.WriteLine(str);
            Console.WriteLine(str[1]);

            // Trying to change the value of index 1, like we could do in C. This is not possible, since strings in C# are immutable.
            // This means, we cannot change an existing string and we always know the length of a string. Thus no null terminator is used (0/) in C#.
        
                /* str[1] = 'B'; */

            // Instead we need to allocate a completely different string in memory. 
            // Then a garbage collector will remove the old string.

                str = "Hello Lars";
                Console.WriteLine(str);

            // Here we use the variable str to reference two different strings. But the actual strings in memory are not changed.

            // Remember how malloc and calloc was used for dynamic space allocation. Here we can just use a List:
            // Also notice "var" type, and talk about pros and cons.
                var nums = new List<int> { 1, 2, 6 };

                nums.Add(5);
                nums.Add(2);

            // When iterating over a list, we use use a foreach loop. Here we declare a variable num, that will represent elements in the list nums.
                foreach(var num in nums)
                {
                    Console.WriteLine(num);
                }

            // Array = fixed in size
            // List  = can change the size

            // Command-line arguments for example: dotnet run 666 420
            // NOTE: In C, the first element argv[0] contained the name of the program.
            // Here args[0] is the first command-line argument, which would be argv[1] in C.
            // Console.WriteLine("First argument is: " + args[0]);
            // Console.WriteLine("Second argument is: " + args[1])    
        }
    }
}
