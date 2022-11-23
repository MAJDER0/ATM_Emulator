## ATM Emulator

Very simple ATM Emulator written in C# with EntityFramework.

### How to run?

Well, since it was written for practice purposes, you'll need to get MS SQL Server installed on your computer first.
When you get MS SQL Server installed on your computer, open MS SQL. You'll see window with Server Name (.\SQLEXPRESS). Before you click connect,
make sure to copy paste whole Server Name path. 
Once you connect, click NEW QUERY (Icon on the top of screen or you can also use shortcut which is CTR + N).
Afterwards, all you want to do is just simply copy paste this command: Create database ATM; 
When you paste it, click F5 to execute it.

Now, all we want to do is Open Visual Studio and click Clone a Repository. On the repository location, you'll paste this: https://github.com/MAJDER0/ATM_Emulator
and click clone.

When you already see the project opened, we want to go AtmContext class which is located in Entities Folder.
Once we're in, we click CTRL + F and enter this: .UseSqlServer to find the method in which we want to swap Server=XXX\\SQLEXPRESS
   So basically, all you have to do is to copy your Server name which you copied before, and replace it right here : Server=YOUR_SERVER_NAME;
   
   It should look more over like this: .UseSqlServer("Server=Your_Server_Name;Database=ATM;Encrypt=False;Trusted_Connection=True;");
   
   Save changes(CTRL+S)

The last thing we need to do, is to make sure that entities and data are properly connected with database. To do this, we click Tools tab
(top of screen in Visual Studio) and we look for NetGet Package Manager. Once we find it, we choose Package Manager Console.
Console will be shown on the bottom of screen. You copy and paste this to the console: Update-Database

Once you're done, you can run a program. 
