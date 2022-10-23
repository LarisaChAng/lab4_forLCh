using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_for_2LCh
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число N");
            int n = Convert.ToInt32(Console.ReadLine());
            int s = 0;
            //double m = 0;

            for (int i = 1; i <= n; i++)
            {
                s += 2 * i - 1;
                //m = Math.Pow(s, 2);

                Console.WriteLine(s);
            }

            Console.ReadKey();
        }
    }
}
