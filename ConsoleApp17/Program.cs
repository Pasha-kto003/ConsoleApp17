using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
       class program
        {
            static void Main(string[] args)
            {
              Cat  c = new Cat("Vladik", new DateTime(2010, 05, 25));
                c.MakeNoise();
                Console.WriteLine($"Кошке по имени {c.Name} уже {c.GetAge()} лет");
                c.HungryStatus = 150;
                Console.ReadLine();
            }
        }
    }
    

