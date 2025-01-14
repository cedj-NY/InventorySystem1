// See https://aka.ms/new-console-template for more information

char returns;
bool EXIT = true;
bool LOGIN_Q = false;

//Main Menu Generation Function
char main_menu()
{
    Console.WriteLine("\t\tInventory System v0.0.1");
    Console.WriteLine("\t1.Inventory\t2.Receiving");
    Console.WriteLine("\t3.Shipping \t4.Admin");
    Console.WriteLine("\t5.Exit");
    char detectKey = Console.ReadKey().KeyChar;
    Console.Clear();
    return detectKey;
}
//Login method to get into system
bool login_prompt()
{
    //User credentials form
    Console.Write("Enter username: ");
    Console.ReadLine();
    Console.Write("\nEnter password: ");
    Console.ReadLine();

    //TODO User Auth
    Console.Clear();
    return true;
}

char inventory_menu()
{
    Console.WriteLine("\t\tInventory System v0.0.1 - Inventory SubMenu");
    return 'e';
}

char receiving_menu()
{
    Console.WriteLine("\t\tInventory System v0.0.1 - Receiving SubMenu");
    return 'e';
}

char shipping_menu()
{
    Console.WriteLine("\t\tInventory System v0.0.1 - Shipping SubMenu");
    return 'e';
}

char admin_menu()
{
    Console.WriteLine("\t\tInventory System v0.0.1 - Admin SubMenu");
    return 'e';
}

//Super fucky wucky main loop
void main()
{
    char submenu_return = ' ';
    do
    {
        LOGIN_Q = login_prompt();
        do
        {
            submenu_return = ' ';
            returns = main_menu();
            switch (returns)
            {
                case '1':
                    Console.Clear();
                    do
                    {
                        submenu_return = inventory_menu();
                    }
                    while (submenu_return != 'e');
                    break;
                case '2':
                    Console.Clear();
                    do
                    {
                        submenu_return = receiving_menu();
                    }
                    while (submenu_return != 'e');
                    break;
                case '3':
                    Console.Clear();
                    do
                    {
                        submenu_return = shipping_menu();
                    }
                    while (submenu_return != 'e');
                    break;
                case '4':
                    Console.Clear();
                    break;
                case '5':
                    Console.Clear();
                    EXIT = false;
                    LOGIN_Q = false;
                    break;
            }
        }
        while (LOGIN_Q);
    }
    while (EXIT);
}

main();