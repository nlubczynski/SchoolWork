using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebTechAssignment3
{
    public class Member
    {
        private string name;
        private string instrument;
        private string joinDate;

        public Member(string name, string instrument)
        {
            this.name = name;
            this.instrument = instrument;
            this.joinDate = "";
        }

        public string getName()
        {
            return this.name;
        }
        public string getInstrument()
        {
            return this.instrument;
        }
        public bool setJoinDate(string date)
        {
            try
            {
                this.joinDate = date;
            }
            catch
            {
                return false;
            }
            return true;
        }
        public string getJoinDate()
        {
            return this.joinDate;
        }
    }
}
