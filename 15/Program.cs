using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15
{
    class Program
    {
        static void Main(string[] args)
        {
            int peshoDamage = int.Parse(Console.ReadLine());
            int goshoDamage = int.Parse(Console.ReadLine());

            int peshoHealth = 100;
            int goshoHealth = 100;
            var round = 1;

            while (true)
            {
                if (round%2==1)
                {
                    goshoHealth -= peshoDamage;
                }
                else
                {
                    peshoHealth -= goshoDamage;
                }
                round++;

                if (peshoHealth <= 0)
                {
                    break;
                }
                if (goshoHealth <= 0)
                {
                    break;
                }
                if (round%3==0)
                {
                    goshoHealth += 10;
                    peshoHealth += 10;
                }
            }
        }
    }
}
