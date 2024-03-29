using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessLayer.Interfaces;
using ModelLayer;
using RepositoryLayer.Entity;
using RepositoryLayer.Interfaces;

namespace BussinessLayer.Services
{
    public class ReviewBusiness:IReviewBusiness
    {
        private readonly IReviewRepo _reviewRepo;

        public ReviewBusiness(IReviewRepo reviewRepo)
        {
            _reviewRepo = reviewRepo;
        }

        public ReviewModel AddReview(ReviewModel model, int userid)
        {
            return _reviewRepo.AddReview(model, userid);
        }

        public List<Review> GetReviews(int bookid)
        {
            return _reviewRepo.GetReviews(bookid);
        }


    }
}
