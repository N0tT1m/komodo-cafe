using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoCafe
{
    public class MenuRepository : IMenuRepository
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

        public bool AddItemToMenu(Menu itemToAdd)
        {
            int startingCount = _menu.Count;
            try
            {
                _menu.Add(itemToAdd);
            }
            catch (Exception)
            {
                Console.WriteLine("Item could not be added to menu");
            }
            bool wasAdded = (_menu.Count > startingCount);
            return wasAdded;
        }

        public bool DeleteItemFromMenu(int itemToDelete)
        {
            int startingCount = _menu.Count;
            try
            {
                foreach (Menu item in _menu)
                {
                    if (item.MealNumber == itemToDelete)
                    {
                        int index = _menu.IndexOf(item);
                        _menu.RemoveAt(index);
                    }
                }
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("Item deleted");
            }
            bool wasRemoved = (_menu.Count < startingCount);
            return wasRemoved;
        }

        public List<Menu> GetAllItemsOnMenu()
        {
            return _menu;
        }
    }
}
