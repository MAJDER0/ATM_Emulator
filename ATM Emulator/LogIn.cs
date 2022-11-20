using ATM_Emulator.Enitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ATM_Emulator
{
    public class LogIn
    {
        public static string login;
        public static string password;

        public void Log()
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("\nPlease enter your login: \n");
                Console.ResetColor();

                login = Console.ReadLine();

                if (!string.IsNullOrEmpty(login))
                {


                    using (var context = new AtmContext())
                    {
                        var user = context.Logins.FirstOrDefault(a => a.Username == login);

                        if (user != null)
                        {
                            enterpassword:
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.WriteLine("\nPlease enter Password: \n");
                            Console.ResetColor();

                            password = Console.ReadLine();

                            if (!string.IsNullOrEmpty(password))
                            {
                                using (var context2 = new AtmContext())
                                {
                                    var passwordcheck = context.Logins.FirstOrDefault(b => b.Password == password);

                                    if (passwordcheck != null)
                                    {
                                        HomeScreen.Screen();
                                    }
                                    else 
                                    {

                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                        Console.WriteLine("\nInvalid Password. Press any key to try again!\n");
                                        Console.ResetColor();
                                        Console.ReadLine();
                                        goto enterpassword;

                                    }
                                }
                            }
                            else 
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("Password can not be Empty. Press any key to try again!\n");
                                Console.ResetColor();
                                Console.ReadLine();
                                goto enterpassword;
                            }

                        }
                        else 
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("\nGiven Login does not exist. Please enter correct one!\n");
                            Console.ResetColor();
                            continue;
                        }

                    }


                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Login can not be Empty. Press any key to try again!\n");
                    Console.ResetColor();
                    Console.ReadLine();
                    continue;
                }

                break;
            }
        }
    }
}
