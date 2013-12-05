using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebTechAssignment5
{
    public class Song
    {
        private string name;
        private string length;

        public Song()
        {
            this.name = "";
            this.length = "";
        }
        public string getName()
        {
            return this.name;
        }
        public string getlength()
        {
            return this.length;
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
        public bool setLength(string length)
        {
            try
            {
                this.length = length;
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
