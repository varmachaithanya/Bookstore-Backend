using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;
using RepositoryLayer.Entity;

namespace BussinessLayer.Interfaces
{
    public interface IReviewBusiness
    {
        public ReviewModel AddReview(ReviewModel model, int userid);

        public List<Review> GetReviews(int bookid);


    }
}
