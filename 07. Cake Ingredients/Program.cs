using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int n = 0;
            while (input!="Bake!")
            {
                Console.WriteLine($"Adding ingredient {input}.");
                n++;
                input = Console.ReadLine();
            }
            Console.WriteLine($"Preparing cake with {n} ingredients.");
        
        }
    }
}
