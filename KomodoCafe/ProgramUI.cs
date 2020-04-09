using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoCafe
{
    class ProgramUI
    {
        public void Run()
        {
            UserInputHelper userInputHelper = new UserInputHelper();
            Menu menu = new Menu();
            MenuRepository repo = new MenuRepository();
            // List<Menu> itemsOnMenu = repo.GetAllItemsOnMenu();

            bool running = true;

            while(running)
            {
                Console.WriteLine("Please select one of the following options\n" +
                    "1: Look at all the menu items\n" +
                    "2: Add a menu item\n" +
                    "3: Delete a menu item\n" +
                    // TODO: "4: Place an order\n"
                    "4: Press Q to exit");

                try
                {
                    int input = int.Parse(Console.ReadLine());
                    switch (input)
                    {
                        case 1:
                            List<Menu> itemsOnMenu = repo.GetAllItemsOnMenu();
                            menu.PrintMenu(itemsOnMenu);
                            break;
                        case 2:
                            menu = userInputHelper.GetItemFromUser();
                            repo.AddItemToMenu(menu);
                            break;
                        case 3:
                            break;
                        case 4:
                            break;
                        case 5:
                            Console.WriteLine("BYEEE");
                            running = false;
                            break;

                    }

                }
                catch (FormatException)
                {
                    Console.WriteLine("That is not a number!");
                };
                
            }
            Console.ReadLine();
        }
    }
}
