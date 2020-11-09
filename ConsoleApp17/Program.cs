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
            Cat c = new Cat("Vladik", new DateTime(2010, 05, 25));
            c.MakeNoise();
            Console.WriteLine($"Кошке по имени {c.Name} уже {c.GetAge()} лет");
            //c.HungryStatus = 150;

            Cat ct = new Cat($"Ваня", new DateTime(2011, 09, 11));
            ct.MakeNoise();
            Console.WriteLine($"Кошке по имени {ct.Name} уже {ct.GetAge()} лет");


            CatSmartHouse catSmartH = new CatSmartHouse(900);
            catSmartH.AddCat(c);
            catSmartH.AddCat(ct);
          
            Console.SetCursorPosition(0, catSmartH.CatsCount + 1);
            Console.ReadLine();
        }

        
        }

    }

    

