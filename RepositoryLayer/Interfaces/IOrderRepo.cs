using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;
using RepositoryLayer.Entity;

namespace RepositoryLayer.Interfaces
{
    public interface IOrderRepo
    {
        public List<Book> AddToOrder(OrderModel model, int userid);

        public List<Book> GetOrders(int userid);

        public double GetPriceInOrder(int userid);




    }
}
