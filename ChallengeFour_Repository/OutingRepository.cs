using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeFour_Repository
{
    public class OutingRepository
    {
        public List<OutingContent> _outingList = new List<OutingContent>();

        //Display List of all outings
        public void DispalyAllOutings()
        {
            foreach (OutingContent outing in _outingList)
            {
                Console.WriteLine($"Event Type: " + outing.EventType + "\n" +
                        "Attendee Count: " + outing.AttendeeCount + "\n" +
                        "Event Date: " + outing.EventDate + "\n" +
                        "Cost Per Person: " + outing.CostPerPerson + "\n" +
                        "Total Cost of Event: " + outing.TotalEventCost + "\n" +
                        "\n");
            }
        }

        //Read
        public List<OutingContent> GetOutingList()
        {
            return _outingList;
        }

        //Add Individual Outings
        public void AddOuting (OutingContent outing)
        {
            _outingList.Add(outing);
        }

        //Display Combined Cost for all outings
        public void EventsTotalCost()
        {
            decimal totalCost = 0;
            foreach (OutingContent outing in _outingList)
            {
                totalCost += outing.TotalEventCost;
            }
            Console.WriteLine("Total cost of events: $" + totalCost);
            
        }

        //Display Cost by Type

        public EventType ReturnOutingType()
        {
            Console.WriteLine("What event would you like to look up? (Golf, Bowling, Amusement Park, or Concert");

            string choice = Console.ReadLine();
            EventType eventType = EventType.Golf;
            
            if (choice.ToLower() == "golf")
            {
                eventType = EventType.Golf;
            }

            else if (choice.ToLower() == "bowling")
            {
                eventType = EventType.Bowling;
            }

            else if (choice.ToLower() == "amusement park")
            {
                eventType = EventType.AmusementPark;
            }

            else if (choice.ToLower() == "concert")
            {
                eventType = EventType.Concert;
            }

            else
            {
                Console.WriteLine("Please enter Golf, Bowling, Amusement Park, or Concert \n" +
                    "\n" +
                    "Press any key to continue");
                Console.ReadKey();
                ReturnOutingType();
            }
            return eventType;
        }


        public void EventTypeTotalCost()
        {
            EventType eventType = ReturnOutingType();
            decimal eventTypeCost = 0;            
            
            foreach (OutingContent outing in _outingList)
            {
                if(outing.EventType == eventType)
                {
                    eventTypeCost += outing.TotalEventCost;
                }
            }

            Console.WriteLine("Total Cost for " + eventType + " is $" + eventTypeCost);
        }
    }
}
