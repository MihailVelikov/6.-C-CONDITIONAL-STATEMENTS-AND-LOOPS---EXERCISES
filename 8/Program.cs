using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int calories = 0;
            
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine().ToLower();
                if (input=="cheese")
                {
                    calories += 500;
                }
                else if (input == "tomato sauce")
                {
                    calories += 150;
                }
                else if (input == "salami")
                {
                    calories += 600;
                }
                else if (input == "pepper")
                {
                    calories += 50;
                }
                //input = Console.ReadLine();
            }
            Console.WriteLine($"Total calories: {calories}");
        }
    }
}
