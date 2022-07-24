using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyektoCSharp
{
    class EventRegistration
    {
        private int registrationID;
        private Customer customer;
        private Event events;
        private string date;

        public EventRegistration(int regId, Customer cust, Event ev)
        {
            registrationID = regId;
            customer = cust;
            events = ev;
            date = date = DateTime.Now.ToString(@"MM\/dd\/yyyy h\:mm tt");
        }

        public int getId() { return registrationID; }
        public Customer getCustomer() { return customer; }
        public Event getEvent() { return events; }
        public string getDate() { return date; }
        public override string ToString()
        {
            string s = "[rID" + registrationID + "]: ";
            s += customer.getFirstName() + " ";
            s += customer.getLastName();
            s += " wil be attending ";
            s += events.getEventName();
            s += ". [";
            s += date + "]";

            return s;
        }
    }
}
