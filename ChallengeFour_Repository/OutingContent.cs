using System;
using System.Diagnostics.Tracing;

namespace ChallengeFour_Repository
{    
    public enum EventType
    {
        Golf, 
        Bowling, 
        AmusementPark, 
        Concert,
    }

    public class OutingContent
    {
        public EventType EventType { get; set; }
        public int AttendeeCount { get; set; }
        public DateTime EventDate { get; set; }
        public decimal CostPerPerson { get; set; }
        public decimal TotalEventCost
        {
            get
            {
                return AttendeeCount * CostPerPerson;
            }
        }

        public OutingContent() { }

        public OutingContent(EventType eventType, int attendeeCount, DateTime eventDate, decimal costPerPerson)
        {
            EventType = eventType;
            AttendeeCount = attendeeCount;
            EventDate = eventDate;
            CostPerPerson = costPerPerson;
        }
    }
}
