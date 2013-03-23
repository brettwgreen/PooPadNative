using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooPadNative
{
    public class Baby
    {
        public string BabyName { get; set; }
        public List<DiaperEvent> DiaperEvents { get; set; }
        public Baby(string babyName)
        {
            BabyName = babyName;
            DiaperEvents = new List<DiaperEvent>();
        }

        public void AddPeeEvent()
        {
            DiaperEvents.Add(new DiaperEvent(DiaperEventType.Pee));
        }

        public void AddPooEvent(string color)
        {
            DiaperEvents.Add(new DiaperEvent(DiaperEventType.Poo, color));
        }

    }

    public enum DiaperEventType
    {
        Poo,
        Pee
    }

    public class DiaperEvent 
    {
        public DiaperEventType EventType { get; set; }
        public DateTime EventTime { get; set; }
        public string EventColor { get; set; }
        public DiaperEvent(DiaperEventType eventType)
        {
            EventType = eventType;
            EventTime = DateTime.Now;
            EventColor = "";
        }
        public DiaperEvent(DiaperEventType eventType, string eventColor) : this(eventType)
        {
            EventColor = eventColor;
        }
    }

}
