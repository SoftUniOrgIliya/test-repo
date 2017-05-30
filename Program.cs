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
            for (int i = 1; i < 20; i++)
            {
                Console.WriteLine("asd");
            }
            string profession = Console.ReadLine();
            if (profession != "Athlete")
            {
                Console.WriteLine("melon");
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
