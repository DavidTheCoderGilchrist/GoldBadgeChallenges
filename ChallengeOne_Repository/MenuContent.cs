using System;

namespace ChallengeOne_Repository
{
    public class MenuContent
    {
        public int MealNumber { get; set; }
        public string MealName { get; set; }
        public string Description { get; set; }
        public string ListOfIngredients { get; set; }
        public double Price { get; set; }

        public MenuContent() { }

        public MenuContent(int mealNumber, string mealName, string description, string listOfIngredients, double price)
        {
            MealNumber = mealNumber;
            MealName = mealName;
            Description = description;
            ListOfIngredients = listOfIngredients;
            Price = price;
        }
    }
}
