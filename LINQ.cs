using System.LINQ;

namepsace MyProgram
{
    public class LINQ 
    {
        // LINQ stands for Language Integrated Query
        // It is a way to query data from various data structures such as arrays and lists in a declarative way.
        // The syntax is very readable and reminds me of SQL queries.
        // What is a query anyway? - A request for information. Essentially a question or statement that describes the data you want.
        // Let's look at the IEnumerable interface - we have to include using System.LINQ;

        

        RandomIntegers List<int> = {8, 32, 11, 3, 67, 1092, 44}

        IEnumerable<int> IntegersAboveForty =
            from RandomInteger in RandomIntegers
            where RandomInteger > 40
            select RandomInteger;

    
        foreach (var i in IntegersAboveForty)
        {
            Console.Write(i + " ")
        }
    }
}