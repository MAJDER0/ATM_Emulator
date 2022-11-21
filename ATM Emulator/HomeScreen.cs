using ATM_Emulator.Enitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Emulator
{
    public class HomeScreen
    {
        public static void Screen()
        {
            while (true)
            {
            start:

                using (var context = new AtmContext())
                {
                    decimal AccountBalance = context.Logins.SingleOrDefault(a => a.Username == LogIn.login).AccountBalance;
                    int choosenOption;

                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine($"\nHello, {LogIn.login}. Welcome to your Virtual Panel\n");
                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine($"Current balance: {AccountBalance}$\n");
                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("What would you like to do?\n");
                    Console.ResetColor();

                    Console.WriteLine("(1)Deposit Money\n");
                    Console.WriteLine("(2)Withdraw Money\n");
                    Console.WriteLine("(3)See your transaction history\n");
                    Console.WriteLine("(4)Logout\n");

                    int.TryParse(Console.ReadLine(), out choosenOption);

                    if (choosenOption == 1)
                    {
                        decimal DepositValue;
                    enterdeposit:

                        try
                        {
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.WriteLine("\nPlease enter how much would you like to deposit: \n");
                            Console.ResetColor();

                            DepositValue = decimal.Parse(Console.ReadLine());
                            context.Logins.SingleOrDefault(a => a.Username == LogIn.login).AccountBalance += DepositValue;
                            context.Logins.SingleOrDefault(a => a.Username == LogIn.login).TransacationHistory += $"+{DepositValue},";
                            context.SaveChanges();

                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("\nFunds have been added to your account. Press any key to continue");
                            Console.ResetColor();
                            Console.ReadLine();
                            Console.Clear();
                            goto start;
                        }
                        catch
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Incorrect operation, please try again\n");
                            Console.ResetColor();
                            goto enterdeposit;

                        }

                    }

                    if (choosenOption == 2)
                    {

                        decimal WithDrawValue;
                    enterwithdraw:

                        try
                        {
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.WriteLine("\nPlease enter how much would you like to withdraw: \n");
                            Console.ResetColor();
                            WithDrawValue = decimal.Parse(Console.ReadLine());

                            if ((context.Logins.SingleOrDefault(a => a.Username == LogIn.login).AccountBalance -= WithDrawValue) > 0)
                            {
                                context.Logins.SingleOrDefault(a => a.Username == LogIn.login).AccountBalance -= WithDrawValue-WithDrawValue;
                                context.Logins.SingleOrDefault(a => a.Username == LogIn.login).TransacationHistory += $"-{WithDrawValue},";
                                context.SaveChanges();

                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.WriteLine("\nFunds have been withdrawn.Press any key to continue");
                                Console.ResetColor();
                                Console.ReadLine();
                                Console.Clear();
                                goto start;
                            }
                            else
                            {
                                context.Logins.SingleOrDefault(a => a.Username == LogIn.login).AccountBalance = 0;
                                context.SaveChanges();
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.WriteLine("\nFunds have been withdrawn.Press any key to continue");
                                Console.ResetColor();
                                Console.ReadLine();
                                Console.Clear();
                                goto start;
                            }
                        }
                        catch
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Incorrect operation, please try again\n");
                            Console.ResetColor();
                            goto enterwithdraw;

                        }

                    }

                    if (choosenOption == 3)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("\nThis is your transaction history. Press any key to come back.\n");
                        Console.ResetColor();

                        Console.WriteLine(context.Logins.SingleOrDefault(a => a.Username == LogIn.login).TransacationHistory);

                        Console.ReadLine();
                        Console.Clear();
                        goto start;
                    }

                    if (choosenOption == 4)
                    {
                        Console.Clear();
                        break;
                    }

                    else
                    {
                        Console.Clear();
                        continue;
                    }

                }
            }
        }

    }
}
