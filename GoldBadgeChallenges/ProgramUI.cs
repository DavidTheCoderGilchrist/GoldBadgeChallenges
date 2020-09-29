﻿using ChallengeOne_Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Challengeone_Console
{
    class ProgramUI
    {
        private MenuContentRepository _itemRepo = new MenuContentRepository();
        public void Run()
        {
            Menu();
        }

        //Manager Menu
        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {

                //Display Options to Manager
                Console.WriteLine("Hello Komodo Cafe Manager!\n" +
                    "\n" +
                    "Please Select an Option:\n" +
                    "1. Add New Menu Item\n" +
                    "2. Delete a Menu Item\n" +
                    "3. See All Menu Items by Name\n" +
                    "4. Exit");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        CreateNewMenuItem();
                        Console.WriteLine("The menu has been updated");
                        break;
                    case "2":
                        DeleteMenuItem();
                        break;

                    case "3":
                        DisplayAllItems();
                        break;

                    case "4":
                        Console.WriteLine("Goodbye!");
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number");
                        break;
                }

                Console.WriteLine("\n" +
                    "Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        private void CreateNewMenuItem()
        {
            Console.Clear();
            MenuContent newItem = new MenuContent();

            //Meal Name
            Console.WriteLine("Enter the name of the new menu item");
            newItem.MealName = Console.ReadLine();
            Console.Clear();

            //Meal Number
            Console.WriteLine("Enter the meal number of the new menu item");
            string itemNumber = Console.ReadLine();
            newItem.MealNumber = int.Parse(itemNumber);
            Console.Clear();

            //Description
            Console.WriteLine("Enter the description of the menu item");
            newItem.Description = Console.ReadLine();
            Console.Clear();

            //List of Ingredients
            Console.WriteLine("Please list all of the ingredients of the new menu item");
            newItem.ListOfIngredients = Console.ReadLine();
            Console.Clear();

            //Price
            Console.WriteLine("What is the price of the item?");        
            Console.Write("$");
            string itemPrice = Console.ReadLine();
            newItem.Price = double.Parse(itemPrice);
            Console.Clear();

            _itemRepo.AddItemsToList(newItem);
        }

        private void DeleteMenuItem()
        {

        }

        private void DisplayAllItems()
        {

        }
    }
}
