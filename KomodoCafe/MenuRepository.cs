using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoCafe
{
    class MenuRepository : IMenuRepository
    {
        private List<Menu> _menu = new List<Menu>()
        {
            new Menu()
            {
                MealNumber = 1,
                MealName = "Big Mac",
                Description = "Heart attack between two buns",
                Ingredients = new List<string>()
                {
                    "Patty",
                    "Big Mac Sauce",
                    "Pickles",
                    "Cheese",
                    "Lettuce"
                },
                Price = 8.99
            }
        };

        public void AddItemToMenu(Menu itemToAdd)
        {
            try
            {
                _menu.Add(itemToAdd);
            }
            catch (Exception)
            {
                Console.WriteLine("Item could not be added to menu");
            }
        }

        public void DeleteItemFromMenu(Menu itemToDelete)
        {
            try
            {
                _menu.Add(itemToDelete);
            }
            catch (Exception)
            {
                Console.WriteLine("Item could not be deleted from menu");
            }
        }

        public List<Menu> GetAllItemsOnMenu()
        {
            return _menu;
        }
    }
}
