using System.Linq;

namespace MyProgram
{
        public class Program
    {
        static void Main(string[] args)
        {
         
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