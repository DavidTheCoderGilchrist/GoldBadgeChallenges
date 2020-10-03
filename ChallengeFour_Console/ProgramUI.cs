using ChallengeFour_Repository;
using System;


namespace ChallengeFour_Console
{
    class ProgramUI
    {
        private OutingRepository _outingRepo = new OutingRepository();
        
        public void Run()
        {
            SeedOutingList();
            Menu();
        }

        //Menu

        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                Console.Clear();
                //Display Options to Manager
                Console.WriteLine("Welcome to the Komodo Outings Database!\n" +
                    "\n" +
                    "Please Select an Option:\n" +
                    "1. Display All Outings\n" +
                    "2. Add Outing to List\n" +
                    "3. Display Combined Cost of all Outings\n" +
                    "4. Display Cost for Outings by Type\n" +
                    "5. Exit");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("List of Company Outings this year\n" +
                            "");

                        _outingRepo.DispalyAllOutings();
                      
                        break;
                    case "2":
                        Console.WriteLine("Please enter the following information \n" +
                            "");
                        AddOuting();
                        break;

                    case "3":
                       _outingRepo.EventsTotalCost();
                        break;
                    case "4":
                        
                        _outingRepo.EventTypeTotalCost();
                        
                        break;

                    case "5":
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

        private void AddOuting()
        {
            Console.Clear();
            OutingContent newOuting = new OutingContent();

            Console.WriteLine("What is the type of the event: Golf, Bowling, Amusement Park, Concert");
            string choice = Console.ReadLine();


            if (choice.ToLower() == "golf")
            {
                EventType eventType  = EventType.Golf;
            }

            else if (choice.ToLower() == "bowling")
            {
                EventType eventType = EventType.Bowling;
            }

            else if (choice.ToLower() == "amusement park")
            {
                EventType eventType = EventType.AmusementPark;
            }

            else if (choice.ToLower() == "concert")
            {
                EventType eventType = EventType.Concert;
            }

            else
            {
                Console.WriteLine("Please enter Golf, Bowling, Amusement Park, or Concert \n" +
                    "\n" +
                    "Press any key to continue");
                Console.ReadKey();
                AddOuting();
            }

            Console.WriteLine("How many people attended? (numbers only please)");
            string attendees = Console.ReadLine();
            newOuting.AttendeeCount = int.Parse(attendees);

            Console.WriteLine("What was the date of the event? (mm/dd/yyyy)");
            string date = Console.ReadLine();
            newOuting.EventDate = DateTime.Parse(date);

            Console.WriteLine("What was the cost per person?");
            Console.Write("$ ");
            string cost = Console.ReadLine();
            newOuting.CostPerPerson = decimal.Parse(cost);

            _outingRepo.AddOuting(newOuting);

            Console.WriteLine("\n" +
                "Outing Added \n" +
                "\n" +
                "Press any key to return to main menu");
            Console.ReadKey();
            Menu();

        }

        private void SeedOutingList()
        {
            OutingContent outingOne = new OutingContent(EventType.Bowling, 20, new DateTime(2020, 8, 8), 20.00m);
            OutingContent outingTwo = new OutingContent(EventType.AmusementPark, 50, new DateTime(2020, 10, 1), 50.00m);
            OutingContent outingThree = new OutingContent(EventType.Concert, 30, new DateTime(2020, 7, 15), 30.00m);

            _outingRepo.AddOuting(outingOne);
            _outingRepo.AddOuting(outingTwo);
            _outingRepo.AddOuting(outingThree);
        }
    }
}
