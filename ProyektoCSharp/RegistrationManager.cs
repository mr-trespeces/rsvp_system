using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyektoCSharp
{
    class RegistrationManager
    {
        private int currentRegistrationId;
        private int maxRegistration;
        private int numRegistration;
        private EventRegistration[] registrationtList;

        public RegistrationManager(int idSeed, int max)
        {
            currentRegistrationId = idSeed;
            maxRegistration = max;
            numRegistration = 0;
            registrationtList = new EventRegistration[maxRegistration];
        }
        public bool addEventRegistration(Customer customerId, Event eventId)
        {
            if (numRegistration >= maxRegistration) { return false; }
            EventRegistration er = new EventRegistration(currentRegistrationId, customerId, eventId);
            registrationtList[numRegistration] = er;
            numRegistration++;
            currentRegistrationId++;
            return true;
        }
        public bool rsvpExist(int cid, int eid)
        {
            for (int x = 0; x < numRegistration; x++)
            {
                if (cid == registrationtList[x].getCustomer().getId() && eid == registrationtList[x].getEvent().getEventId())
                {
                    return true;
                }
            }
            return false;
        }

        public string viewAllRegistration()
        {
            string s = "";
            for (int x = 0; x < numRegistration; x++)
            {
                s = s + "\n" + registrationtList[x].ToString();
            }
            return s;
        }
    }
}
