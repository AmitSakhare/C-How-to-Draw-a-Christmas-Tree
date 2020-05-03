using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("By Denis Rafi");
            Console.WriteLine("-----------------");
            int n = int.Parse(Console.ReadLine());
            
            Console.WriteLine("{0}*{0}",
                new string('_', n));

            for (int i = 0; i < (n / 2); i++)
            {
                Console.WriteLine("{0}{1}{0}",
                    new string('_', ((n - 1) - i)),
                    new string('*', (((n * 2) + 1) - (((n - 1) - i) * 2))));
            }

            for (int i = 0; i < ((n / 2) + 1); i++)
            {
                Console.WriteLine("{0}{1}{0}",
                    new string('_', ((n - 1) - i)),
                    new string('*', (((n * 2) + 1) - (((n - 1) - i) * 2))));
            }

            for (int i = 0; i < ((n / 2) + 1); i++)
            {
                Console.WriteLine("{0}{1} {1}{0}",
                    new string('_', (n - 1)),
                    new string('|', 1));
            }
            Console.WriteLine("{0}",
                new string('_', ((n * 2) + 1)));          
        }       
    }
}
