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
            c.HungryStatusChanged += C_HungryStatusChanged;

            Cat cat2 = new Cat($"Ваня", new DateTime(2011, 09, 11));
            Console.WriteLine($"Коту по имени {cat2.Name} уже {cat2.GetAge()} лет");
            cat2.HungryStatusChanged += Cat2_HungryStatusChanged;
            }

        private static void Cat2_HungryStatusChanged(object sender, EventArgs e)
        {
            Random rnd = new Random();
            Cat cat2 = (Cat)sender;
            if (cat2.HungryStatus < 20 && rnd.Next(0, 10) < 5)
                cat2.Feed();
            else
                cat2.GetStatus();
        }

        private static void C_HungryStatusChanged(object sender, EventArgs e)
        {
            Random rnd = new Random();
            Cat cat = (Cat)sender;
            if (cat.HungryStatus < 20 && rnd.Next(0, 10) < 5)
                cat.Feed();
            else
                cat.GetStatus();
        }
    }
    }
    

