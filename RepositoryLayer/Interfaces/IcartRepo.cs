using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;
using RepositoryLayer.Entity;

namespace RepositoryLayer.Interfaces
{
    public interface IcartRepo
    {
        public List<Book> AddToCart(CartModel model, int userid);


        public List<Book> GetCartBooks(int userid);

        public double GetPrice(int userid);

        public CartModel UpdateQuantity(int userid, CartModel model);

        public bool DeleteCart(DeleteCart model);





    }
}
