using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Console2
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Console.Write("Сколько чисел ввести? n = ");
            int n = int.Parse(Console.ReadLine());

            double[] numbers = new double[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Введите число {i + 1}: ");
            
                numbers[i] = double.Parse(Console.ReadLine());
                
                
            }

            int evenCount = 0;
            int oddCount = 0;

            for (int i = 0; i < n; i++)
            {
                if (numbers[i] % 2 == 0) 
                evenCount++;
                    else oddCount++;
            }
            Console.WriteLine($"\nЧётных: {evenCount}");
            Console.WriteLine($"Нечётных: {oddCount}");
        }
    }
}
