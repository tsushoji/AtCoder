using System;

namespace ABC087B
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var A = int.Parse(Console.ReadLine());
            var B = int.Parse(Console.ReadLine());
            var C = int.Parse(Console.ReadLine());
            var X = int.Parse(Console.ReadLine());

            var result = 0;

            for (var i = 0; i <= C; i++)
            {
                var CValue = 50 * i;
                var sumBAndA = X - CValue;
                if (CValue > X || sumBAndA > X)
                {
                    break;
                }
                for (var j = 0; j <= B; j++)
                {
                    if (sumBAndA == 0 && i != 0 && j == 0) 
                    {
                        result++;
                        continue;
                    }

                    var BValue = 100 * j;
                    var AValue = sumBAndA - BValue;
                    if (BValue > X || AValue > X)
                    {
                        break;
                    }

                    if ((CValue + BValue) == X)
                    {
                        result++;
                        continue;
                    }

                    if (A ==0) 
                    {
                        continue;
                    }

                    var ADevideValue = AValue / 500;
                    if (AValue % 500 == 0 && (0 < ADevideValue && ADevideValue <= A)) 
                    {
                        result++;
                    }
                }
            }

            Console.WriteLine(result.ToString());
        }
    }
}
