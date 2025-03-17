using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPROG2
{
    class Market 
    {
        public int Price { get; set; }
    }

    class MainActivity
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select (1-3): ");
            int num = Convert.ToInt32(Console.ReadLine());

            switch(num)
            {
                case 1:
                    Console.WriteLine("This is 1");
                    break;
                case 2:
                    Console.WriteLine("This is 2");
                    break;
                case 3:
                    Console.WriteLine("This is 3");
                    break;

                default:
                    break;
            }

        }
    }
}