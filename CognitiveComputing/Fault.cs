using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CognitiveComputing
{
    class Fault
    {
        ArrayList faultVars = new ArrayList();
        private string sCompanyName;
        private string sContactNumber;
        private string sType;
        private string sDescription;
        private int iThreatLevel;
        private string sStatus;

        public Fault()
        {
            sCompanyName = "Not Set";
            sContactNumber = "000 000 000";
            sType = "Not Set";
            sDescription = "Not Set";
            iThreatLevel = 0;
            sStatus = "None";
        }

        public Fault(string name, string contact, string type, string description, int threat, string status)
        {
            sCompanyName = name;
            sContactNumber = contact;
            sType = type;
            sDescription = description;
            iThreatLevel = threat;
            sStatus = status;
        }

        public void setCompanyName(string name)
        {
            sCompanyName = name;
        }

        public void setContact(string contact)
        {
            sContactNumber = contact;
        }

        public void setType(string type)
        {
            sType = type;
        }

        public void setDescription(string description)
        {
            sDescription = description;
        }

        public void setThreat(int threat)
        {
            iThreatLevel = threat;
        }

        public void setStatus(string status)
        {
            sStatus = status;
        }

        public ArrayList getFaultVars()
        {
            faultVars.Add(sCompanyName);
            faultVars.Add(sContactNumber);
            faultVars.Add(sType);
            faultVars.Add(sDescription);
            faultVars.Add(iThreatLevel);
            faultVars.Add(sStatus);
            return faultVars;
        }

        public override string ToString()
        {
            return sCompanyName + ", " + sContactNumber + ", " + sType + ", " + sDescription + ", " + iThreatLevel + ", " + sStatus;
        }

    }
}
