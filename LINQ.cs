using System.Linq;

namespace MyProgram
{
    public class LINQ 
    {
        // NOTE: This file is exclueded from compiling and should be pasted in Program.cs for testing - See CS-Teaching.csproj

        // LINQ stands for Language Integrated Query
        // It is a way to query data from various data structures such as arrays and lists in a declarative way.
        // The syntax is very readable and reminds me of SQL queries.
        // What is a query anyway? - A request for information. Essentially a question or statement that describes the data you want.
        // Let's look at the IEnumerable interface - we have to include using System.LINQ;

        // Making a list of integers
        List<int> RandomIntegers = [8, 32, 11, 3, 67, 1092, 44];

        // Making an IEnumerable of integers. (Defining the question - what do we want?)
        IEnumerable<int> IntegersAboveForty =
            from RandomInteger in RandomIntegers
            where RandomInteger > 40
            select RandomInteger;

        // Executing the IEnumerable. (Asking the question - A query isn't executed until you iterate over the query variable)
        foreach (var i in IntegersAboveForty)
            {
                Console.Write(i + " ");
            }
        }

        // Another Example using strings:
        List<string> RandomStrings = ["Yolo", "Swag", "Dude", "Where", "Is", "My", "Car"];

        IEnumerable<string> StringsLengthOf4 =
            from RandomString in RandomStrings
            where RandomString.Length == 4
            select RandomString;

        foreach (var i in StringsLengthOf4)
            {
                Console.Write(i + " ");
            }
        }
    }
}