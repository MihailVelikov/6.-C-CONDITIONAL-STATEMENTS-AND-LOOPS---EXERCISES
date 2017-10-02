using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            for (int i = a; i <= b; i++)
            {
                Console.WriteLine(i);
            }
            if (a>b)
            {
                for (int i = b; i <= a; i++)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
