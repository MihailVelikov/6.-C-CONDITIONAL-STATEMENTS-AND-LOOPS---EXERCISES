using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            string prof = Console.ReadLine();
            double count = double.Parse(Console.ReadLine());
            if (prof == "Athlete")
            {
                count *= 0.7;
                Console.WriteLine("The {0} has to pay {1:F2}.",prof,count);
            }
            else if (prof == "Businessman" || prof == "Businesswoman")
            {
                count *= 1;
                Console.WriteLine("The {0} has to pay {1:F2}.", prof, count);
            }
            else if (prof == "SoftUni Student")
            {
                count *= 1.7;
                Console.WriteLine("The {0} has to pay {1:F2}.", prof, count);
            }
            else
            {
                count *= 1.2;
                Console.WriteLine("The {0} has to pay {1:F2}.", prof, count);
            }
        }
    }
}
