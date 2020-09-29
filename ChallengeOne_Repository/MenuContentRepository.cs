using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeOne_Repository
{
    public class MenuContentRepository
    {
        private List<MenuContent> _listOfItems = new List<MenuContent>();

        //Create

        public void AddItemsToList(MenuContent items)
        {
            _listOfItems.Add(items);
        }

        //Read

        public List<MenuContent> GetItemsList()
        {
            return _listOfItems;
        }

        //Delete

        public bool RemoveItemsFromList(string mealName)
        {
            MenuContent items = GetItemsByMealName(mealName);

            if (items == null)
            {
                return false;
            }

            int initialCount = _listOfItems.Count;
            _listOfItems.Remove(items);

            if(initialCount > _listOfItems.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Helper Method
        private MenuContent GetItemsByMealName(string mealName)
        {
            foreach (MenuContent items in _listOfItems)
            {
                if (items.MealName.ToLower() == mealName.ToLower())
                {
                    return items;
                }
            }

            return null;
        }
    }
}
