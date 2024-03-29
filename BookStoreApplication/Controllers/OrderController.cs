using BussinessLayer.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelLayer;

namespace BookStoreApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {

        private readonly IorderBusiness business;

        public OrderController(IorderBusiness business)
        {
            this.business = business;
        }

        [HttpPost]
        [Route("AddOrder")]

        public IActionResult Add_order(OrderModel model,int userid)
        {
            var data=business.AddToOrder(model,userid);
            if(data!=null)
            {
                return Ok(data);
            }
            return BadRequest();
        }

        [HttpGet]
        [Route("GetAllOrder")]


        public IActionResult Get_all_orders(int userid) 
        {
            var data=business.GetOrders(userid);
            if(data!=null)
            {
                return Ok(data);
            }
            return BadRequest();
        }

        [HttpGet]
        [Route("GetOrderPrice")]

        public IActionResult Get_order_price(int userid)
        {
            var data=business.GetPriceInOrder(userid);
            if (data != null)
            {
                return Ok(data);
            }
            return BadRequest();
        }
    }
}
