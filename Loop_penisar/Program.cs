using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_penisar
{
    class Program
    {
        static void Main(string[] args)
        {

            string product;
            int number;
            int money;
            int loop = 1;

            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("What is your product called? ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(">");
                Console.ForegroundColor = ConsoleColor.White;

                Console.Read();
                product = Console.ReadLine();

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("How many do you want to produce?");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(">");
                Console.ForegroundColor = ConsoleColor.White;

                number = Convert.ToInt32(Console.ReadLine());

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("How much USD will you sell them for individually?");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(">");
                Console.ForegroundColor = ConsoleColor.White;

                money = Convert.ToInt32(Console.ReadLine());

                Console.Clear();
                for (int i = 1; i <= number; i++)
                {
                    Console.WriteLine(product + " Nr." + i);

                    if (i == number)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Done!");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine();
                        Console.WriteLine("You produced" + " " + i + " " + product + "'s, ");
                        Console.WriteLine();
                        Console.WriteLine("and you sold {0} of them, ", i / 2);
                        Console.Write("giving you a total earning of ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("${0} USD. ", money * i / 2);
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("(Hit enter to see your money progress.)");

                        Console.Read();

                        Console.Clear();
                        for (int j = 0; j <= money * i / 2; j++)
                        {
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("$");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Write(j);
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.Write(" USD");
                            
                            if (j == money * i / 2)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine(); 
                                Console.WriteLine("Done!");
                                Console.WriteLine();
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.WriteLine("Hit enter to restart.");
                                Console.Read();                            
                            }
                            
                        }
                    }
                }


                Console.Read();
            }
            while (loop == 1);
        }
    }
}
