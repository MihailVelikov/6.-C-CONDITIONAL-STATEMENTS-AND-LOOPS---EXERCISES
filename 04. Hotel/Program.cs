using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());
            double studio;
            double dvoen;
            double suite;
            if (month=="May" || month=="October")
            {
                studio = 50*days;
                dvoen = 65 * days;
                suite = 75 * days;
                if (days>7)
                {
                    studio = (50 * 0.95) * days;
                }
                if (month=="October" && days>7)
                {
                    studio = (50 * 0.95) * (days - 1);
                }
                Console.WriteLine("Studio: {0:F2} lv.",studio);
                Console.WriteLine("Double: {0:F2} lv.",dvoen);
                Console.WriteLine("Suite: {0:F2} lv.",suite);
            }
            else if (month == "June" || month == "September")
            {
                studio = 60 * days;
                dvoen = 72 * days;
                suite = 82 * days;
                if (days>14)
                {
                    dvoen = (72 * 0.9) * days;
                }
                if (month == "September" && days > 7)
                {
                    studio = 60 * (days - 1);
                }
                Console.WriteLine("Studio: {0:F2} lv.", studio);
                Console.WriteLine("Double: {0:F2} lv.", dvoen);
                Console.WriteLine("Suite: {0:F2} lv.", suite);
            }
            else if (month == "July" || month == "August" || month=="December")
            {
                studio = 68 * days;
                dvoen = 77 * days;
                suite = 89 * days;
                if (days>14)
                {
                    suite = (89 * 0.85) * days;
                }
                Console.WriteLine("Studio: {0:F2} lv.", studio);
                Console.WriteLine("Double: {0:F2} lv.", dvoen);
                Console.WriteLine("Suite: {0:F2} lv.", suite);
            }
           
        }
    }
}
