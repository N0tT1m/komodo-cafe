using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoCafe
{
    class Menu
    {
        public Menu()
        {

        }

        public int MealNumber { get; set; }
        public string MealName { get; set; }
        public string Description { get; set; }
        public List<string> Ingredients { get; set; }
        public double Price { get; set; }

        public void PrintMenu(List<Menu> items)
        {
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine($"Meal Number:\n\t{items[i].MealNumber}\nMeal Name:\n\t{items[i].MealName}\nMeal Description:\n\t{items[i].Description}");
                Console.WriteLine("Ingredients: ");
                foreach (string ingredient in items[i].Ingredients)
                {
                    System.Console.WriteLine("\t" + ingredient);
                }
                Console.WriteLine($"Price:\n\t{items[i].Price}"); 
            }
        }
    }
}
