using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());
            char c = char.Parse(Console.ReadLine());
            for (char i = a; i <= b; i++)
            {
                if (i != c)
                {
                    for (char k = a; k <= b; k++)
                    {
                        if (k != c)
                        {
                            for (char n = a; n <= b; n++)
                            {
                                if (n!=c)
                                {
                                    Console.Write("{0}{1}{2} ", i, k, n);
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
