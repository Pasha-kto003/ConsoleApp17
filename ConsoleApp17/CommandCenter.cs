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
            WaitCommand(CatSmartHouse);
        }
        public CatSmartHouse CatSmartHouse
        { get; set; }

        

        private void WaitCommand(CatSmartHouse catSmartHouse)
        {

            string command = "";
            while (command != "exit")
            {
                Console.SetCursorPosition(0, CatSmartHouse.CatsCount + 2);
                command = Console.ReadLine();
                string[] array = command.Split();
                if (array[0] == "store")
                {
                    int smth = Convert.ToInt32(array[2]);
                    CatSmartHouse.FoodResourse += smth;
                    Console.Write(array[1]);
                }

                if (array[0] == "cls")
                {
                    for (int i = 5; i < 10; i++)
                    {
                        Console.SetCursorPosition(0, i);
                        for (int j = 0; j < 100; j++)
                        {
                            Console.Write(' ');
                        }
                    }
                }
                else if (command == "help")
                {
                    Console.WriteLine("Добавить еды в вольер: store название еды количество еды");
                    Console.WriteLine("Очистить консоль: cls");
                    Console.WriteLine("Изменить границу голода: ChangeHungryLimit +/- на сколько");
                    Console.WriteLine("Выход: exit");
                }
                if (array[0] == "ChangeHungryLimit+++")
                {
                    if (array[1] == "+")
                    {
                        catSmartHouse.hangryLimit -= Convert.ToInt32(array[2]);
                    }
                    else if (array[1] == "-")
                    {
                        catSmartHouse.hangryLimit += Convert.ToInt32(array[2]);
                    }
                }
            }
        }
    }
}

