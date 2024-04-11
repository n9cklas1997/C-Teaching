namespace MyProgram
{
        public class Program
    {
        static void Main(string[] args)
        {
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
}