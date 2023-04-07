using System;

class Program
{
    public static void Main()
    {
        // Title
        Console.WriteLine(  "**************SVB Bank**************");
        Console.WriteLine("::Login Page!!");

        // declare variables
        string userName = null, password = null;

        // read userName from keyboard
        Console.WriteLine("Username: ");
        userName = Console.ReadLine();

        // check if user enterd password
        if(userName !=  "")
        {
            Console.WriteLine("Password: ");
            password = Console.ReadLine();
        }

        // check username and password
        if(userName == "system" && password == "manager")
        {
            // variable to store mennu choice
            int userChoice = -1;

            do
            {
                Console.WriteLine("\n:::Main menu:::");
                Console.WriteLine("1. Customers");
                Console.WriteLine("2. Accounts");
                Console.WriteLine("3. Funds transfare");
                Console.WriteLine("4. Funds Tranfare Statement");
                Console.WriteLine("5. Account Statement");
                Console.WriteLine("0. Exit!");

                Console.WriteLine("Enter choice: ");
                userChoice = int.Parse(Console.ReadLine());

                // switch-case to check menu choice
                switch (userChoice)
                {
                    case 1: CustomerMenu();
                        break;
                    case 2: //TODO: display customer menu
                        break;
                    case 3: //TODO: display customer menu
                        break;
                    case 4: //TODO: display customer menu
                        break;
                    case 5: //TODO: display customer menu
                        break;
                }
            } while (userChoice != 0);

        }
        else
        {
            Console.WriteLine("Invalid username or password");
        }

        // exit
        Console.WriteLine("Thank you! Visit again");
        Console.ReadKey();
    }

    static void CustomerMenu()
    {
        // user choice
        int userChoice = -1;

        // do-while

        do
        {
            // print customer menu
            Console.WriteLine("\n:::Customer Menu:::");
            Console.WriteLine("1. Add Customer");
            Console.WriteLine("2. Delete Customer");
            Console.WriteLine("3. Uodate Customer");
            Console.WriteLine("4. View Customer");
            Console.WriteLine("0. Back To Main menu");

            //accept customer menu choice
            Console.WriteLine("Enter Choice");
            userChoice = Convert.ToInt32(Console.ReadLine());

        } while(userChoice != 0);

 
    }
}