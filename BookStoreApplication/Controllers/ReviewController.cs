using BussinessLayer.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelLayer;

namespace BookStoreApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewController : ControllerBase
    {

        private readonly IReviewBusiness business;

        public ReviewController(IReviewBusiness business) 
        { 
            this.business = business;
        }

        [HttpGet]

        public IActionResult Getreview(int bookid)
        {
            var data=business.GetReviews(bookid);
            if (data == null)
            {
                return NotFound();
            }
            return Ok(data);
        }

        [HttpPost]
        public IActionResult Add_review(ReviewModel model,int userid)
        {
            var data=business.AddReview(model,userid);
            if (data == null)
            {
                return NotFound();
            }
            return Ok(data);
        }
        
    }
}
