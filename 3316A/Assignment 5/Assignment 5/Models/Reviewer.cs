using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebTechAssignment3
{
    public class Reviewer
    {
        private string id;
        private string name;
        private string company;

        public Reviewer(string id)
        {
            this.id = id;
            this.name = "";
            this.company = "";
        }
        public bool setName(string name)
        {
            try
            {
                this.name = name;
            }
            catch
            {
                return false;
            }
            return true;
        }
        public override string ToString()
        {
            return this.name;
        }
        public string getName()
        {
            return this.name;
        }
        public string getId()
        {
            return this.id;
        }

        public string getCompany()
        {
            return this.company;
        }

       public bool setCompany(string company)
        {
            try
            {
                this.company = company;
            }
            catch
            {
                return false;
            }
            return true;
        }

       internal void setId(string id)
       {
           this.id = id;
       }
    }
}
