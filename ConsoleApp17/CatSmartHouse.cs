using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class CatSmartHouse
    {
        List<Cat> cats = new List<Cat>();

        public CatSmartHouse(int foodResourse)
        {
            FoodResourse = foodResourse;
        }
        public int FoodResourse
        { get; set; }

        public void AddCat(Cat cat)
        {
            cats.Add(cat);
            cat.HungryStatusChanged += Cat_HungryStatusChanged;

        }
        private void Cat_HungryStatusChanged(object sender, EventArgs e)
        {
            var cat = (Cat)sender;
            if (cat.HungryStatus <= 20 && FoodResourse > 0)
            {
                byte needFood = (byte)(100 - cat.HungryStatus);
                if (FoodResourse > needFood)
                    FoodResourse -= needFood;
                else
                {
                    needFood = (byte)FoodResourse;
                    FoodResourse = 0;
                }
                cat.Feed(needFood);
                Console.WriteLine($"Покормлена кошка: {cat.Name}\nОстаток еды в вольере: {FoodResourse}");
            }
        }
    }
}

