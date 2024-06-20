using System;

namespace ABC086A
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var inputLineArray = Console.ReadLine().Split(" ");

            var resultNum = int.Parse(inputLineArray[0]) * int.Parse(inputLineArray[1]);

            Console.WriteLine(resultNum % 2 == 0 ? "Even": "Odd");
        }
    }
}
