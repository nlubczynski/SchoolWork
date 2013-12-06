using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebTechAssignment5
{
    public class Show
    {
        private string date;
        private string venue;

        public Show()
        {
            this.date = "";
            this.venue = "";
        }
        public Show(string date, string venue)
        {
            this.date = date;
            this.venue = venue;
        }

        public void setDate(string date)
        {
            this.date = date;
        }
        public void setVenue(string venue)
        {
            this.venue = venue;
        }
        public string getDate()
        {
            return this.date;
        }
        public string getVenue()
        {
            return venue;
        }
    }
}
