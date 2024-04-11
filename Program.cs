using System.Linq;

namespace MyProgram
{
        public class Program
    {
        static void Main(string[] args)
        {
         
        // Making a list of integers
        List<int> RandomIntegers = [8, 44, 32, 11, 3, 67, 1092, 44];

        // Making an IEnumerable of integers. (Defining the question - what do we want?)
        IEnumerable<int> IntegersAboveForty =
           (from RandomInteger in RandomIntegers
            where RandomInteger > 40
            select RandomInteger).Distinct();

        // After where, you could for example have: orderby RandomInteger ascending/descending to sort the list in the query
        // You can also apply methods to the query itself. For example we put the query inside (), and then we say .Distinct().
        // The Distinct method takes only unique examples in the list.

        // Executing the IEnumerable. (Asking the question - A query isn't executed until you iterate over the query variable)
        foreach (int i in IntegersAboveForty)
            {
                Console.Write(i + " ");
            }
        }
    }
}