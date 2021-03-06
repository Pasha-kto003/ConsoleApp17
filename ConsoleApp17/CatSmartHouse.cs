﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class CatSmartHouse
    {
        public object printing = true;

        public int hangryLimit = 20;
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
        public int CatsCount
        {
            get
            {
                return cats.Count;
            }
        }
        private void Cat_HungryStatusChanged(object sender, EventArgs e)
        {
            var cat = (Cat)sender;
            if (cat.HungryStatus <= 20 && FoodResourse > 0)
            {
                sbyte needFood = (sbyte)(100 - cat.HungryStatus);
                if (FoodResourse > needFood)
                    FoodResourse -= needFood;
                else
                {
                    needFood = (sbyte)FoodResourse;
                    FoodResourse = 0;
                }
                cat.Feed(needFood);
                PrintStatus();
            }
        }
        public void PrintStatus()
        {

            {
                lock (printing)
                {
                    int leftPosition = Console.CursorLeft;
                    int topPosition = Console.CursorTop;

                    for (var i = 0; i < cats.Count; i++)
                    {
                        string message = cats[i].GetStatus("");
                        int color = Convert.ToInt32(message.Substring(0, 1)); //substring - извель символ
                        Console.SetCursorPosition(0, i);
                        Console.ForegroundColor = (ConsoleColor)color;
                        Console.Write(message.Substring(2).Trim().PadRight(50, ' '));
                        Console.ResetColor();
                    }
                    Console.SetCursorPosition(0, cats.Count);
                    Console.Write($" {FoodResourse}".PadRight(50));
                    Console.SetCursorPosition(leftPosition, topPosition);
                }
            }
            // Console.WriteLine($"Покормлена кошка: {cat.Name}\nОстаток еды в вольере: {FoodResourse}");
        }
    }

}    

                
            

            
        
 



