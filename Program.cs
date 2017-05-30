using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Choose_a_Drink
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            var cnt = 0;
            
            if (profession == "Athlete")
            {
                Console.WriteLine("melon");
                cnt++;
            }
            else if (profession == "Businessman" || profession == "Businesswoman")
            {
                Console.WriteLine("Coffee");
            }
            else if (profession == "SoftUni Student")
            {
                Console.WriteLine("tea");
            }
            else
            {
                Console.WriteLine("beer");
            }
            
        }
    }
}
