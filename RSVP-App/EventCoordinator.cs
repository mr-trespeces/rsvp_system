using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyektoCSharp
{
    public class EventCoordinator
    {
        CustomerManager custMan;
        EventManager eventMan;
        RegistrationManager regMan;

        public EventCoordinator(int custIdSeed, int maxCust, int eventIdSeed, int maxEvents, int regIdSeed, int maxReg)
        {
            custMan = new CustomerManager(custIdSeed, maxCust);
            eventMan = new EventManager(eventIdSeed, maxEvents);
            regMan = new RegistrationManager(regIdSeed, maxReg);
        }

        //customer related methods
        public bool addCustomer(string fname, string lname, string phone)
        {
            return custMan.addCustomer(fname, lname, phone);
        }
        public string customerList()
        {
            return custMan.getCustomerList();
        }
        public string getCustomerInfoById(int id)
        {
            return custMan.getCustomerInfo(id);
        }
        public bool deleteCustomer(int id)
        {
            return custMan.deleteCustomer(id);
        }
        // Event related methods
        public bool addEvent(string name, string venue, Date eventDate, int maxAttendee)
        {
            return eventMan.addEvent(name, venue, eventDate, maxAttendee);
        }
        public string eventList()
        {
            return eventMan.getEventList();
        }
        public string getEventInfoById(int id)
        {
            return eventMan.getEventInfo(id);
        }
        // Registration related methods
        public bool rsvpConfirmation(int custId, int eventId)
        {
            Customer cust = custMan.getCustomer(custId);
            Event ev = eventMan.getEvent(eventId);
            if (cust != null && ev != null)
            {
                if (regMan.rsvpExist(custId, eventId)) { return false;  }
                if (ev.getNumAttendees() == ev.getMaxAttendees()) { return false; }
                if (regMan.addEventRegistration(cust, ev))
                {
                    cust.incrementBooking();
                    ev.addAttendee(cust);
                    return true;
                }
            }
            return false;
        }

        public string getRSVPconfList()
        {
            return regMan.viewAllRegistration();
        }
    }
}
