using System;

namespace ABC081A
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var result = 0;

            var firstInput = Console.Read();
            if (firstInput == '1') 
            {
                result++;
            }

            var secondInput = Console.Read();
            if (secondInput == '1')
            {
                result++;
            }

            var thirdInput = Console.Read();
            if (thirdInput == '1')
            {
                result++;
            }

            Console.WriteLine(result.ToString());
        }
    }
}
