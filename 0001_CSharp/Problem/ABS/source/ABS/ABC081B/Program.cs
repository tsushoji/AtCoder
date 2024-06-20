using System;

namespace ABC081B
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            var inputArray = Console.ReadLine().Split(" ");

            var result = 0;

            while (!IsEnd(inputArray, N)) 
            {
                result++;
            }
            if (result > 0) 
            {
                result += 1;
            }

            Console.WriteLine(result.ToString());
        }

        private static Boolean IsEnd(string[] inputArray, int arraySize) 
        {
            for (var i = 0; i < arraySize - 1; i++) 
            {
                var updateValue = int.Parse(inputArray[i]) / 2;
                if (updateValue % 2 != 0) 
                {
                    return true;
                }
                inputArray[i] = updateValue.ToString();
            }

            return false;
        }
    }
}
