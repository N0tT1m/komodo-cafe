using System;
using System.Collections.Generic;
using KomodoCafe;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MenuRepositoryTests
{
    [TestClass]
    public class RepsitoryTests
    {
        MenuRepository repo = new MenuRepository();
        Menu menu = new Menu()
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
        };

        [TestMethod]
        public void AddItemToMenu_ShouldAdd()
        {
            bool wasAdded = repo.AddItemToMenu(menu);
            Assert.IsTrue(wasAdded);
        }

        [TestMethod]
        public void DeleteItemFromMenu_ShouldDelete()
        {
            bool wasRemoved = repo.DeleteItemFromMenu(menu.MealNumber);
            Assert.IsTrue(wasRemoved);
        }

        [TestMethod]
        public void GetAllMenuItems_ShouldReturnList()
        {
            List<Menu> menuItems = repo.GetAllItemsOnMenu();

            List<Menu> menu1 = repo.GetAllItemsOnMenu();
            List<Menu> menu2 = menuItems;

            Assert.AreEqual(menu1, menu2);
        }
    }
}
