using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
           int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var inputChar = i + 1;
                Console.WriteLine(new string(inputChar.ToString, i + 1));
            }
        }
    }
}
