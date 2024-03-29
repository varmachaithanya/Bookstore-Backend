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
    public class CartBusiness : IcartBusiness
    {
        private readonly IcartRepo _cartRepo;

        public CartBusiness(IcartRepo cartRepo)
        {
            _cartRepo = cartRepo;
        }
        public List<Book> AddToCart(CartModel model, int userid)
        {
            return _cartRepo.AddToCart(model, userid);
        }

        public List<Book> GetCartBooks(int userid)
        {
            return _cartRepo.GetCartBooks(userid);
        }

        public double GetPrice(int userid)
        {
            return _cartRepo.GetPrice(userid);
        }

        public CartModel UpdateQuantity(int userid, CartModel model)
        {
            return _cartRepo.UpdateQuantity(userid, model);
        }

        public bool DeleteCart(DeleteCart model)
        {
            return _cartRepo.DeleteCart(model);
        }





    }
}
