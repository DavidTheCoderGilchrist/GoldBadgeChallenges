using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ChallengeOne_Repository;
using System.Collections.Generic;

namespace ChallengeOne_Tests
{
    [TestClass]
    public class ChallengeOneTests
    {
        private MenuContentRepository menuTest = new MenuContentRepository();
        
        [TestInitialize]
        public void SeedMenuItemList()
        {
            MenuContent komodoOmelette = new MenuContent(1, "Komodo Omelette", "A two egg omelette served with a your choice of a side", "Eggs, steak, mushrooms, and swiss cheese", 7.45);
            MenuContent komodoChickenAndWaffles = new MenuContent(2, "Komodo Chicken and Waffles", "Pumpkin spice waffles and breaded chicken strips", "Waffles and chicken served with maple syrup", 9.50);
            MenuContent komodoBreakfastBurrito = new MenuContent(3, "Komodo Breakfast Burrito", "A flour tortilla filled with two eggs, sausage, and mixed cheese served with a side", "Eggs, sausage, cheese, and choice of side", 10.50);

            menuTest.AddItemsToList(komodoOmelette);
            menuTest.AddItemsToList(komodoChickenAndWaffles);
            menuTest.AddItemsToList(komodoBreakfastBurrito);

        }

        [TestMethod]
        public void AddItemsToListTest()
        {
            //Arrange
            MenuContent item = new MenuContent(4, "Komodo's Famous Burger", "Best Burger in Town", "Burger, bread, a fries", 9.99);

            //Act
            menuTest.AddItemsToList(item);
            int actual = menuTest.GetItemsList().Count;

            //Assert
            Assert.AreEqual(4, actual);
        }

        [TestMethod]
        public void RemoveItemsListTest()
        {
            //Arrange is set from Test Initialize

            //Act
            bool actual = menuTest.RemoveItemsFromList("Komodo Omelette");

            //Assert
            Assert.AreEqual(true, actual);
        }
    }
}
