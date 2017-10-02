using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 100; i++)
            {
                try
                {
                    int num = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }
    }
}
