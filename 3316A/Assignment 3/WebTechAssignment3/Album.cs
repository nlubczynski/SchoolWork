using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebTechAssignment3
{
    public class Album
    {
        private string name;
        private ArrayList songs;
        private ArrayList reviews;

        public Album(string name)
        {
            this.name = name;
            this.songs = new ArrayList();
            this.reviews = new ArrayList();
        }
        public bool addSong(Song s){
            try
            {
                songs.Add(s);
            }
            catch
            {
                return false;
            }
            return true;
        }
        public Song[] getSongs()
        {
            return (Song[])songs.ToArray(typeof(Song));
        }
        public bool addReviewer(Review r)
        {
            try
            {
                reviews.Add(r);
            }
            catch
            {
                return false;
            }
            return true;
        }
        public Review[] getReviewers()
        {
            return (Review[])reviews.ToArray(typeof(Reviewer));
        }

        internal string getName()
        {
            return this.name;
        }

        internal Review[] getReviews()
        {
            return (Review[])this.reviews.ToArray(typeof(Review));
        }

        internal void addReview(Review r)
        {
            reviews.Add(r);
        }
    }
}
