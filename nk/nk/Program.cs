using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nk
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, S;
            Console.WriteLine("Вычислите произведение двух чисел: ");
            Console.Write("Введите первое число: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число:");
            n2 = Convert.ToInt32(Console.ReadLine());
            S = n1 * n2;
            Console.Write("Ответ:" + S);
            Console.ReadKey();
        }
    }
}
