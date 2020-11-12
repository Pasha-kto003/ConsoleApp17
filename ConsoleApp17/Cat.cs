﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{

    public class Cat
    {
        public int a = 10;
        public int b = 40;
        public int c = 70;
        public int d = 90;
        sbyte _hungryStatus;
        public event EventHandler HungryStatusChanged;
        public Cat(string name, DateTime birthday)

        {
            Name = name;
            BirthDay = birthday;
            Task.Run(LifeCircle);
        }

        public string Name
        {
            get;
            set;
        }
        public void MakeNoise()
        {
            Console.WriteLine($"{Name} мяукает");
        }
        public DateTime BirthDay
        {
            get; set;
        }
        public int GetAge()
        {
            return (DateTime.Today - BirthDay).Days / 365;
        }

        public sbyte HungryStatus
        {
             get { return _hungryStatus; }
            set
            {
                sbyte status = value;
                if (status < 0)
                {
                    status = 0;
                }
                else if (status > 100)
                {
                    status = 100;
                }
                else
                    _hungryStatus = value;
                if (_hungryStatus < status)
                {
                    HungryStatusChanged?.Invoke(this, null);
                }
                _hungryStatus = status;

            }
           
        }
        public void Feed(sbyte needFood)
        {
            HungryStatus += needFood;
        }

        public string GetStatus(string color)

        {
            // Console.WriteLine(Name);
            //Console.WriteLine($"Возраст: {GetAge()}");
            
            
            if (HungryStatus <= a)
            {
               color = Convert.ToString(Convert.ToInt32(Console.ForegroundColor = ConsoleColor.DarkRed));
                //Console.WriteLine("Кошка умирает от голода");
            }
            else if (HungryStatus > a && HungryStatus <= b)
            {
                color = Convert.ToString(Convert.ToInt32(Console.ForegroundColor = ConsoleColor.Red));
               // Console.WriteLine("Кошка очень голодна");
            }
            else if (HungryStatus > b && HungryStatus <= c)
            {
                color = Convert.ToString(Convert.ToInt32(Console.ForegroundColor = ConsoleColor.DarkYellow));
               // Console.WriteLine("Кошка хочет кушать");
            }
            else if (HungryStatus > c && HungryStatus <= d)
            {
                color = Convert.ToString(Convert.ToInt32(Console.ForegroundColor = ConsoleColor.Yellow));
              //  Console.WriteLine("Кошка не против перекусить");
            }
            else if (HungryStatus > d)
            {
                color = Convert.ToString(Convert.ToInt32(Console.ForegroundColor = ConsoleColor.Green));
               // Console.WriteLine("Кошка недавно поела");
            }
            string name = Name;
            string age = Convert.ToString(GetAge());
            string status = Convert.ToString(HungryStatus);
            string getstatus = $"{color}, {name} {age} {status}";
            return getstatus;
            // ну или можно так: return color, name, age, status;

            
            
        }

        async Task LifeCircle()
        {

            await Task.Delay(100);
            HungryStatus -= 10;
            await LifeCircle();

        }



    }
}  


