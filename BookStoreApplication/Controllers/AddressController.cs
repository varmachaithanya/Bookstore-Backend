using BussinessLayer.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelLayer;

namespace BookStoreApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private readonly IaddressBusiness business;

        public AddressController(IaddressBusiness business)
        {
            this.business = business;
        }

        [HttpPost]
        [Route("AddAddress")]
        
        public IActionResult add_address(AddressModel model)
        {
            var data=business.AddAddress(model);
            if(data != null)
            {
                return Ok(data);
            }
            return BadRequest();

        }

        [HttpGet]
        [Route("GetAddress")]

        public IActionResult get_address(int userid) 
        {
            var data=business.GetAddresses(userid);
            if( data != null )
            {
                return Ok(data);
            }
            return BadRequest();
        }

        [HttpPut]
        [Route("UpdateAddress")]

        public IActionResult update_address(AddressModel model)
        {
            var data=business.UpdateAddress(model);
            if(data != null)
            {
                return Ok(data);
            }
            return BadRequest();
        }
    }
}
