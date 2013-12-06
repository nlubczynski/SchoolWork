﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace WebTechAssignment5
{
    public class Band
    {
        private string name;
        private string size;
        private ArrayList members;
        private ArrayList albums;
        private List<Show> shows;

        public Band(string name, string size)
        {
            this.name = name;
            this.size = size;
            members = new ArrayList();
            albums = new ArrayList();
            shows = new List<Show>();
        }

        public string getSize()
        {
            return this.members.Count.ToString();
        }
        public bool setSize(string size)
        {
            try
            {
                this.size = size;
            }
            catch
            {
                return false;
            }
            return true;
        }


        public bool addMember(Member m){
            try
            {
                members.Add(m);
            }
            catch
            {
                return false;
            }
            return true;
        }
        public Member[] getMembers()
        {
            return (Member[])members.ToArray(typeof(Member));
        }
        public bool addAlbum(Album a)
        {
            try
            {
                albums.Add(a);
            }
            catch
            {
                return false;
            }
            return true;
        }
        public Album[] getAlbums()
        {
            return (Album[])albums.ToArray(typeof(Album));
        }
        public bool addShow(Show s)
        {
            try
            {
                shows.Add(s);
            }
            catch
            {
                return false;
            }
            return true;
        }
        public Show[] getShows()
        {
            return shows.ToArray();
        }
        public string getName()
        {
            return this.name;
        }

        public void setName(string name)
        {
            this.name = name;
        }
        public void removeMembers()
        {
            this.members = new ArrayList();
        }

        public void removeAlbum(Album albumHighlight)
        {
            albums.Remove(albumHighlight);
        }
        public override string ToString()
        {
            return this.name;
        }
        internal void addShows(Show[] show)
        {
            foreach (Show s in show)
                shows.Add(s);
        }
        public void removeShow(Show s)
        {
            shows.Remove(s);
        }
    }
}
