using System;
using System.Net;
using System.Runtime.ExceptionServices;
using System.Text;

namespace Battle_Okhlamonov
{
    class Program
    {
        static void Main(string[] args)
        {
            string UserV;
            Console.Clear();
            Console.WriteLine("Битва Ахламонов");
            Console.Write("Хотите сыграть? ");
            UserV = Console.ReadLine();
            switch (UserV)
            {
                case ("да"):
                    {
                        while (UserV == "да")
                        {
                            Console.Clear();
                            Random rand = new Random();
                            float health1 = rand.Next(90, 100);
                            int damage1 = rand.Next(5, 20);
                            int armour1 = rand.Next(25, 60);

                            float health2 = rand.Next(90, 100);
                            int damage2 = rand.Next(5, 20);
                            int armour2 = rand.Next(25, 60);

                            Console.WriteLine("У второго Ахламона такие значения: ");
                            Console.WriteLine($"{health1} ед. - Здоровья.");
                            Console.WriteLine($"{damage1} ед. - Урона.");
                            Console.WriteLine($"{armour1} ед. - Брони.");
                            Console.WriteLine(" ");
                            Console.WriteLine("У первого Ахламона такие значения: ");
                            Console.WriteLine($"{health2} ед. - Здоровья.");
                            Console.WriteLine($"{damage2} ед. - Урона.");
                            Console.WriteLine($"{armour2} ед. - Брони.");
                            Console.WriteLine(" ");
                            Console.Write("Начнем Эту великую битву? ");
                            UserV = Console.ReadLine();
                            if (UserV == "да")
                            {
                                while (health1 > 0 && health2 > 0)
                                {
                                    health1 -= Convert.ToSingle(rand.Next(0, damage2 + 1)) / 100 * armour1;
                                    health2 -= Convert.ToSingle(rand.Next(0, damage1 + 1)) / 100 * armour2;

                                    Console.WriteLine("Здоровье у первого Ахламона: " + health1);
                                    Console.WriteLine("Здоровье у второго Ахламона: " + health2);
                                }
                                if (health1 <= 0 && health2 <= 0)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Ничья!");
                                    Console.WriteLine($"У них по ровну здоровья, они оба погибли.");
                                    Console.Write("Хотите ли вы сыграть еще раз? ");
                                    UserV = Console.ReadLine();
                                }
                                else if (health1 > health2)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Победил первый Ахламон!");
                                    Console.WriteLine($"У первого Ахламона осталось {health1} здоровья.");
                                    Console.Write("Хотите ли вы сыграть еще раз? ");
                                    UserV = Console.ReadLine();
                                }
                                else if (health2 > health1)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Победил второй Ахламон!");
                                    Console.WriteLine($"У второго Ахламона осталось {health2} здоровья.");
                                    Console.Write("Хотите ли вы сыграть еще раз? ");
                                    UserV = Console.ReadLine();
                                }
                                Console.Clear();
                                Console.WriteLine("Рад был тебя видеть!");
                                Console.WriteLine("Надеюсь вы к нам когда-то вернетесь :)");
                            }
                            else if (UserV == "нет")
                            {
                                Console.Clear();
                                Console.WriteLine("Рад был тебя видеть!");
                                Console.WriteLine("Надеюсь вы к нам когда-то вернетесь :)");
                            }
                        }
                    }
                    break;

                case ("нет"):
                    {
                        Console.Clear();
                        Console.WriteLine("Рад был тебя видеть!");
                        Console.WriteLine("Надеюсь вы к нам когда-то вернетесь :)");
                    }
                    break;
                default:
                    {
                        Console.Clear();
                        Console.WriteLine("Я не понял что вы написали!");
                        Console.WriteLine("Попробуйте написать с маленькой буквы");
                        Console.WriteLine("Перезапустите программу и напишите: да или нет");
                        Console.WriteLine("да - старт/начать");
                        Console.WriteLine("нет - стоп/прекратить");
                    }
                    break;
            }
        }
    }
}