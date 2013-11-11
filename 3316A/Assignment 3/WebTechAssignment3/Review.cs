using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebTechAssignment3
{
    public class Review
    {
        private string reviewerID;
        private string review;

        public Review(string reviewerID)
        {
            this.reviewerID = reviewerID;
            this.review = "";
        }
        public string getReview()
        {
            return review;
        }
        public bool setReview(String review)
        {
            try
            {
                this.review = review;
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
