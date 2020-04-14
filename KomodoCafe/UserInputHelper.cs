using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoCafe
{
    class UserInputHelper
    {
        public Menu GetItemFromUser(Menu menu)
        {
            menu.Ingredients = new List<string>();

            int count = 0;
            bool enteringIngredents = true;
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
                    menu.Ingredients.Add(Console.ReadLine());
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
                        menu.Ingredients.Add(input);
                    }
                }
                count++;
            }
            Console.WriteLine("Please enter a price for the meal: ");
            menu.Price = double.Parse(Console.ReadLine());

            return menu;
        }

        //public int GetMealNumberToDelete()
        //{
        //    Console.WriteLine("What meal would you like to delete?");
        //    int mealNumber = int.Parse(Console.ReadLine());
        //    return mealNumber;
        //}
    }
}
