using System.Linq;

namespace MyProgram
{
        public class Program
    {
        static void Main(string[] args)
        {
         
        List<string> RandomStrings = ["Yolo", "Swag", "Dude", "Where", "Is", "My", "Car"];

        IEnumerable<string> StringsLengthOf4 = RandomStrings.Where(s => s.Length == 4)
                                                            .OrderByDescending(s => s);

        foreach (string s in StringsLengthOf4)
            {
                Console.Write(s + " ");
            }
        }
    }
}