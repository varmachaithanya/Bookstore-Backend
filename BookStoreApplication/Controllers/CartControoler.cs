using BussinessLayer.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelLayer;

namespace BookStoreApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartControoler : ControllerBase
    {
        private readonly IcartBusiness business;

        public CartControoler(IcartBusiness business)
        {
                this.business = business;
        }

        [HttpPost]
        [Route("AddToCart")]
        public IActionResult AddCart(int userid,CartModel model) 
        {
            var data = business.AddToCart(model, userid);
            if (data == null)
            {
                return NotFound();
            }
            return Ok(data);
        }

        [HttpGet]
        [Route("GetCard")]
        public IActionResult GetCard(int userid)
        {
            var data=business.GetCartBooks(userid);
            if(data == null)
            {
                return NotFound();
            }
            return Ok(data);
        }

        [HttpGet]
        [Route("GetCardPrice")]
        public IActionResult GetCardPrice(int userid)
        {
            var data = business.GetPrice(userid);
            if (data == null)
            {
                return NotFound();
            }
            return Ok(data);
        }

        [HttpPut]
        [Route("UpdateQuantity")]
        public IActionResult UpdateQty(int userid, CartModel model)
        {
            var data = business.UpdateQuantity(userid,model);
            if (data == null)
            {
                return NotFound();
            }
            return Ok(data);
        }

        [HttpPost]
        [Route("DeleteCart")]

        public IActionResult Delete_cart(DeleteCart model)
        {
            var data = business.DeleteCart(model);
            if (!data)
            {
                return NotFound("Cart Not found");
            }
            return Ok(new {message="deleted sucessfully",result=true });
        }
    }
}
