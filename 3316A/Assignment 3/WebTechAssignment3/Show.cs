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
        public void setDate(int index, string date)
        {
            this.date.RemoveAt(index);
            this.date.Insert(index, date);
        }
        public void setVenue(int index, string venue)
        {
            this.venue.RemoveAt(index);
            this.venue.Insert(index, venue);
        }
        public void removeDate(int index)
        {
            this.date.RemoveAt(index);
        }
        public void removeVenue(int index)
        {
            this.venue.RemoveAt(index);
        }
    }
}
