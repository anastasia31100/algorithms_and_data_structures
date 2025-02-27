using System;

namespace GuessNumber1
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 0;
            int min = 0;
            int tryCount = 0;
            int gameCount = 0;
            
            Random random = new Random();
            ConsoleKeyInfo tmp;
            do {
                gameCount++;
                int number = random.Next(1, 101);
                int attempCount = 0;
                while (true)
                {
                    attempCount++;
                    Console.WriteLine("Enter you try");
                    int tries = 0;
                    while (!int.TryParse(Console.ReadLine(), out tries)
                        || tries < 1 || tries > 100)
                    Console.WriteLine("Enter you try in [1,100]");
                   
                            Console.WriteLine("Error.Enter correct mumber in [1,100]");
                    if (tries > number)
                        Console.WriteLine("you try in more");
                    else if (tries < number)
                        Console.WriteLine("you try is less");
                    else
                    {
                        Console.WriteLine("you win");
                        break;
                    }
                }
                tryCount += attempCount;
                if (max < attempCount) max = attempCount;
                min = min == 0 || min > attempCount ? attempCount : min;
                //if (min == 0 || min > attempCount) min= attempCount;
                
                Console.WriteLine("Enter Y if you want play again");
                 tmp = Console.ReadKey();
            } while (tmp.Key == ConsoleKey.Y);
            Console.WriteLine($"Max = {max}\nAvg = {tryCount / gameCount} ");
            }

        }
    }

