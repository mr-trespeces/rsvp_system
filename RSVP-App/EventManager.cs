using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyektoCSharp
{
    class EventManager
    {
        private static int currentEventId;
        private int maxEvents;
        private int numEvents;
        private Event[] eventList;

        public EventManager(int idSeed, int max)
        {
            currentEventId = idSeed;
            maxEvents = max;
            numEvents = 0;
            eventList = new Event[maxEvents];
        }

        public bool addEvent(string name, string venue, Date eventDate, int maxAttendees)
        {
            if (venueOccupied(venue, eventDate)) { return false; }
            if (numEvents >= maxEvents) { return false; }
            Event e = new Event(currentEventId, name, venue, eventDate, maxAttendees);
            eventList[numEvents] = e;
            numEvents++;
            currentEventId++;
            return true;
        }

        public bool venueOccupied(string venue, Date date)
        {
            for (int x = 0; x < numEvents; x++)
            {
                if (eventList[x].getVenue().Trim().ToLower() == venue.Trim().ToLower())
                {
                    if (eventList[x].getDate().hour == date.hour
                        && eventList[x].getDate().month == date.month
                        && eventList[x].getDate().year == date.year)
                    {
                        return true;
                    }
                }

            }
            return false;
        }
        private int findEvent(int eid)
        {
            for (int x = 0; x < numEvents; x++)
            {
                if (eventList[x].getEventId() == eid)
                    return x;
            }
            return -1;
        }


        public bool eventExists(int eid)
        {
            int loc = findEvent(eid);
            if (loc == -1) { return false; }
            return true;
        }

        public Event getEvent(int eid)
        {
            int loc = findEvent(eid);
            if (loc == -1) { return null; }
            return eventList[loc];
        }

        public bool deleteEvent(int eid)
        {
            int loc = findEvent(eid);
            if (loc == -1) { return false; }
            eventList[loc] = eventList[numEvents - 1];
            numEvents--;
            return true;
        }
        public string getEventInfo(int eid)
        {
            int loc = findEvent(eid);
            if (loc == -1) { return "There is no event with id " + eid + "."; }
            return eventList[loc].ToString();
        }
        public string getEventList()
        {
            string s = "";
            for (int x = 0; x < numEvents; x++)
            {
                s = s + "\n" + eventList[x].getEventId() + "        " + eventList[x].getEventName() + "                 " + eventList[x].getVenue();
            }
            return s;
        }
    }
}
