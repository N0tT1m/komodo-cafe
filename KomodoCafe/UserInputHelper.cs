using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoCafe
{
    class UserInputHelper
    {
        public Menu GetItemFromUser()
        {
            int count = 0;
            List<string> ingredents = new List<string>();
            bool enteringIngredents = true;
            Menu menu = new Menu();
            Console.WriteLine("Please enter a number for your meal: ");
            menu.MealNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a name for your meal: ");
            menu.MealName = Console.ReadLine();
            Console.WriteLine("Please enter a description for your meal: ");
            menu.Description = Console.ReadLine();
            while (enteringIngredents)
            {
                if (count == 0)
                {
                    Console.WriteLine("Please enter your ingredents: ");
                    ingredents.Add(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("To stop adding ingredents press 'Q' or enter more ingredents: ");
                    string input = Console.ReadLine();
                    if (input.ToLower() == "q")
                    {
                        enteringIngredents = false;
                    }
                    else
                    {
                        ingredents.Add(input);
                    }
                }
                count++;
            }
            Console.WriteLine("Please enter a price for the meal: ");
            menu.Price = double.Parse(Console.ReadLine());

            return menu;
        }
    }
}
