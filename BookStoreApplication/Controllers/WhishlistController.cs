using BussinessLayer.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelLayer;

namespace BookStoreApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WhishlistController : ControllerBase
    {
        private readonly IwhishListBusiness business;

        public WhishlistController(IwhishListBusiness business)
        {
            this.business = business;
        }

        [HttpPost]
        [Route("AddToWishList")]

        public IActionResult Add_whishlist(AddWhishlist model)
        {
            var data = business.AddToWishList(model);

            if(data == null)
            {
                return BadRequest();
            }
            return Ok(data);
        }

        [HttpGet]
        [Route("GetWhishList")]

        public IActionResult get_wishlist(int userid)
        {
            var data = business.GetWhishListBooks(userid);

            if(data == null)
            {
                return BadRequest();
            }

            return Ok(data);
        }

        [HttpPost]
        [Route("DeleteWhishList")]

        public IActionResult delete_whishlist(DeleteCart model)
        {
            var data = business.DeleteWhishlist(model);

            if(data == null)
            {
                return BadRequest();
            }
            return Ok(new {message="deleted sucessfully",result=true});
    }
    }

   
}
