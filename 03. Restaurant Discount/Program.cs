using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            int persons = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            double price = 0;
            double finalprice = 0;
            if (persons<=50)
            {
                if (type=="Normal")
                {
                    price = 2500 + 500;
                    finalprice = (price - price * 0.05) / persons;
                }
                else if (type=="Gold")
                {
                    price = 2500 + 750;
                    finalprice = (price - price * 0.1) / persons;
                }
                else if (type=="Platinum")
                {
                    price = 2500 + 1000;
                    finalprice = (price - price * 0.15) / persons;
                }
                Console.WriteLine("We can offer you the Small Hall");
                Console.WriteLine("The price per person is {0:F2}$",finalprice);
            }
            else if (persons>50 && persons<=100)
            {
                if (type == "Normal")
                {
                    price = 5000 + 500;
                    finalprice = (price - price * 0.05) / persons;
                }
                else if (type == "Gold")
                {
                    price = 5000 + 750;
                    finalprice = (price - price * 0.1) / persons;
                }
                else if (type == "Platinum")
                {
                    price = 5000 + 1000;
                    finalprice = (price - price * 0.15) / persons;
                }
                Console.WriteLine("We can offer you the Terrace");
                Console.WriteLine("The price per person is {0:F2}$", finalprice);
            }
            else if (persons>100 && persons<=120 )
            {
                if (type == "Normal")
                {
                    price = 7500 + 500;
                    finalprice = (price - price * 0.05) / persons;
                }
                else if (type == "Gold")
                {
                    price = 7500 + 750;
                    finalprice = (price - price * 0.1) / persons;
                }
                else if (type == "Platinum")
                {
                    price = 7500 + 1000;
                    finalprice = (price - price * 0.15) / persons;
                }
                Console.WriteLine("We can offer you the Great Hall");
                Console.WriteLine("The price per person is {0:F2}$", finalprice);
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
        }
    }
}
