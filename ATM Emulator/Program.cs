using ATM_Emulator;
using ATM_Emulator.Enitites;
using Microsoft.EntityFrameworkCore;

while (true)
{
    Console.ForegroundColor = ConsoleColor.DarkMagenta;
    Console.WriteLine("\nWelcome to the virtual ATM. Would you like to create your virtual bank account or log in to existing one?\n");
    Console.ResetColor();
    Console.WriteLine("(1) Create an account");
    Console.WriteLine("(2) Log in");

    while (true)
    {
        int ChoosenOption;
        int.TryParse(Console.ReadLine(), out ChoosenOption);

        if (ChoosenOption == 1)
        {
            new CreateAnAccount().Create();
            break;
        }

        if (ChoosenOption == 2)
        {
            new LogIn().Log();
            break;
        }

        else
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\nPlease choose correct operation");
            Console.ResetColor();
            continue;
        }

    }


}


