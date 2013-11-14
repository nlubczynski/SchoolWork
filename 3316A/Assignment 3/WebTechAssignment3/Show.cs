using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebTechAssignment3
{
    public class Show
    {
        private ArrayList date;
        private ArrayList venue;

        public Show()
        {
            this.date = new ArrayList();
            this.venue = new ArrayList();
        }

        public bool addDate(string date){
            try{
                this.date.Add(date);
            }
            catch{
                return false;
            }
            return true;
        }
        public string[] getDates()
        {
            return (string[])date.ToArray(typeof(string));
        }
        public bool addVenue(string venue)
        {
            try
            {
                this.venue.Add(venue);
            }
            catch
            {
                return false;
            }
            return true;
        }
        public string[] getVenues()
        {
            return (string[])venue.ToArray(typeof(string));
        }
    }
}
