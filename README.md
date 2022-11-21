## ATM Emulator

Very simple ATM Emulator written in C# with EntityFramework.

### How to run?

Well, since it was written for practice purposes, you'll need to get MS SQL Server installed on your computer first.
When you get MS SQL Server installed on your computer, open MS SQL. You'll see window with Server Name (.\SQLEXPRESS). Before you click connect,
make sure to copy paste whole Server Name path. 
Once you connect, click NEW QUERY (Icon on the top of screen or you can also use shortcut which is CTR + N).
Afterwards, all you want to do is just simply copy paste this command: Create database ATM; 
When you paste it, click F5 to execute it.

Now, all we wanna do is Open Visual Studio and click Clone a Repository. On the repository location, you paste this: https://github.com/MAJDER0/ATM_Emulator
and click clone.

When you already see the project opened, all we wanna do is go to AtmContext class which is located in Entities Folder.
Once we're in, we click CTRL + F and enter this: .UseSqlServer to find the method in which we want to swap Server=XXX\\SQLEXPRESS
So basically, all you have to do is to copy your Server name which you copied befor here : Server=YOUR_SERVER_NAME;

Once you're done, you can save changes (CTRL+S) and run a program. 
