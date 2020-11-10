using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class CommandCenter
    {

        public CommandCenter(CatSmartHouse catSmartHouse)
        {
            CatSmartHouse = catSmartHouse;
            WaitCommand();
        }

        private void WaitCommand()
        {

        }

        public CatSmartHouse CatSmartHouse
        { get; set; }


        public void WaitCommand(Cat cat)
        {

            string command = "";
            while (command != "exit")
            {
                Console.SetCursorPosition(0, CatSmartHouse.CatsCount + 1);
                command = Console.ReadLine();
                string[] array = command.Split();
                if (array[0] == "store")
                {
                    int smth = Convert.ToInt32(array[2]);
                    CatSmartHouse.FoodResourse += smth;

                }

                if (command == "cls")
                {
                    for (int i = 5; i < 10; i++)
                    {
                        Console.SetCursorPosition(0, i);
                        for (int j = 0; j < 50; j++)
                        {
                            Console.Write(' ');
                        }
                    }
                }
                else if (command == "help")
                {
                    Console.WriteLine("Добавить еды в вольер: store название еды количество еды");
                    Console.WriteLine("Очистить консоль: cls");
                    Console.WriteLine("Измкеит границу голода: ChangeHungryLimit на сколько");
                }
                if (command == "ChangeHungryLimit")
                {
                    if (array[1] == "+")
                    {
                        cat.a -= Convert.ToInt32(array[2]);
                        cat.b -= Convert.ToInt32(array[2]);
                        cat.c -= Convert.ToInt32(array[2]);
                        cat.d -= Convert.ToInt32(array[2]);
                    }
                    else if (array[1] == "-")
                    {
                        cat.a += Convert.ToInt32(array[2]);
                        cat.b += Convert.ToInt32(array[2]);
                        cat.c += Convert.ToInt32(array[2]);
                        cat.d += Convert.ToInt32(array[2]);
                    }
                }
            }
        }
    }
}

