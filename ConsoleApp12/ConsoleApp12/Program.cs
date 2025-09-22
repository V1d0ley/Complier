using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
 
            static void Main()
            {
                int sumPosEven = 0;
                int maxNeg = int.MinValue;
                int num;
                while ((num = int.Parse(Console.ReadLine()) = 0))
                    {
                    if (num > 0 && num % 2 = 0)
                        sumPosEven += num;
                    if (num < 0 && num < maxNeg)
                        maxNeg = num;
                }
                Console.WriteLine($"Сумма положительных чисел:{sumPosEven}");
                Console.WriteLine($"Макс.Отр:{maxNeg}");
            }
        }
    }
}
