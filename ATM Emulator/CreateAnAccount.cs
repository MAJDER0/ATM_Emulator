using ATM_Emulator.Enitites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Emulator
{
    public class CreateAnAccount
    {
        public async void Create()
        {
            while (true)
            {
                string login;
                string password;
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("\nPlease insert your uniqe login below: \n");
                Console.ResetColor();
                login = Console.ReadLine();

                if (!string.IsNullOrEmpty(login))
                {

                    password:

                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("\nNow insert password: \n");
                    Console.ResetColor();



                    password = Console.ReadLine();

                    if (!string.IsNullOrEmpty(password))
                    {
                        var user = new Login { Username = login, Password = password };

                        try
                        {
                            using (var context = new AtmContext())
                            {
                                context.Logins.Add(user);
                                context.SaveChanges();
                            }

                            System.Threading.Thread.Sleep(500);
                            Console.WriteLine("\nPlease wait...");
                            System.Threading.Thread.Sleep(500);
                            Console.WriteLine("Please wait...");
                            System.Threading.Thread.Sleep(500);
                            Console.WriteLine("Please wait...");

                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("\nSuccess! User has been added! Press any key to return menu");
                            Console.ResetColor();

                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }

                        catch
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("\nGiven login already exists. Press any key to try again");
                            Console.ResetColor();
                            Console.ReadLine();
                            continue;
                        }
                    }

                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Password can not be Empty. Press any key to try again!");
                        Console.ResetColor();
                        Console.ReadLine();
                        goto password;
                    }

                }

                else 
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Login can not be Empty. Press any key to try again!");
                    Console.ResetColor();
                    Console.ReadLine();
                    continue;
                }
            }

        }
    }
}
