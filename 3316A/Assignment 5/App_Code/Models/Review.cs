using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebTechAssignment5
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
        public string getReviewerId()
        {
            return this.reviewerID;
        }
        public void setReviewerId(string id)
        {
            this.reviewerID = id;
        }
    }
}
