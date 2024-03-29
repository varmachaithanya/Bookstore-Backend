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
    public class OrderBusiness:IorderBusiness
    {
        private readonly IOrderRepo _repo;

        public OrderBusiness(IOrderRepo repo)
        {
            _repo = repo;
        }
        public List<Book> AddToOrder(OrderModel model, int userid)
        {
            return _repo.AddToOrder(model, userid);
        }

        public List<Book> GetOrders(int userid)
        {
            return _repo.GetOrders(userid);
        }

        public double GetPriceInOrder(int userid)
        {
            return _repo.GetPriceInOrder(userid);
        }



    }
}
