using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please, enter a number: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (num <= 999 && num >= 0)
            {
                int temp = num;

                switch (temp / 100)
                {
                    case 0:
                        break;
                    case 1:
                        Console.Write("Сто ");
                        break;
                    case 2:
                        Console.Write("Двеста ");
                        break;
                    case 3:
                        Console.Write("Триста ");
                        break;
                    case 4:
                        Console.Write("Четиристотин ");
                        break;
                    case 5:
                        Console.Write("Петстотин ");
                        break;
                    case 6:
                        Console.Write("Шестстотин ");
                        break;
                    case 7:
                        Console.Write("Седемстотин ");
                        break;
                    case 8:
                        Console.Write("Осемстотин ");
                        break;
                    case 9:
                        Console.Write("Деветстотин ");
                        break;
                    default:
                        Console.WriteLine("Error report!");
                        break;
                }

                if (temp / 100 != 0 && temp % 100 != 0)
                {
                    Console.Write("и ");
                }

                switch (temp / 10 % 10)
                {
                    case 0:
                        break;
                    case 1:
                        {
                            switch (temp % 10)
                            {
                                case 0:
                                    Console.WriteLine("десет ");
                                    break;
                                case 1:
                                    Console.WriteLine("единадесет ");
                                    break;
                                case 2:
                                    Console.WriteLine("дванайсет ");
                                    break;
                                case 3:
                                    Console.WriteLine("тринайсет ");
                                    break;
                                case 4:
                                    Console.WriteLine("четиранайсет ");
                                    break;
                                case 5:
                                    Console.WriteLine("петнайсет ");
                                    break;
                                case 6:
                                    Console.WriteLine("шестнайсет ");
                                    break;
                                case 7:
                                    Console.WriteLine("седемнайсет ");
                                    break;
                                case 8:
                                    Console.WriteLine("осемнайсет ");
                                    break;
                                case 9:
                                    Console.WriteLine("деветнайсет ");
                                    break;
                                default:
                                    Console.WriteLine("Error report!");
                                    break;
                            }
                        }
                        break;
                    case 2:
                        Console.Write("двайсет и ");
                        break;
                    case 3:
                        Console.Write("трийсет и ");
                        break;
                    case 4:
                        Console.Write("четирсет и ");
                        break;
                    case 5:
                        Console.Write("педесет и ");
                        break;
                    case 6:
                        Console.Write("шейсет и ");
                        break;
                    case 7:
                        Console.Write("седемдесет и ");
                        break;
                    case 8:
                        Console.Write("осемдесет и ");
                        break;
                    case 9:
                        Console.Write("деветдесет и ");
                        break;
                    default:
                        Console.Write("Error report!");
                        break;
                }

                switch (temp % 10)
                {
                    case 0:
                        if (temp == 0)
                        {
                            Console.Write("нула");
                        }
                        Console.Write("\n ");
                        break;
                    case 1:
                        if (temp / 10 % 10 == 1) break;
                        Console.WriteLine("едно");
                        break;
                    case 2:
                        if (temp / 10 % 10 == 1) break;
                        Console.WriteLine("две");
                        break;
                    case 3:
                        if (temp / 10 % 10 == 1) break;
                        Console.WriteLine("три ");
                        break;
                    case 4:
                        if (temp / 10 % 10 == 1) break;
                        Console.WriteLine("четири");
                        break;
                    case 5:
                        if (temp / 10 % 10 == 1) break;
                        Console.WriteLine("пет");
                        break;
                    case 6:
                        if (temp / 10 % 10 == 1) break;
                        Console.WriteLine("шест");
                        break;
                    case 7:
                        if (temp / 10 % 10 == 1) break;
                        Console.WriteLine("седем ");
                        break;
                    case 8:
                        if (temp / 10 % 10 == 1) break;
                        Console.WriteLine("осем ");
                        break;
                    case 9:
                        if (temp / 10 % 10 == 1) break;
                        Console.WriteLine("девет ");
                        break;
                    default:
                        Console.WriteLine("Error report!");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Out of range!");
            } Console.WriteLine();
        }
    }
}