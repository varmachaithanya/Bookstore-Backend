using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;
using RepositoryLayer.Entity;

namespace RepositoryLayer.Interfaces
{
    public interface IwhishListRepo
    {


        public List<Book> AddToWishList(AddWhishlist model);



        public List<Book> GetWhishListBooks(int userid);

        public bool DeleteWhishlist(DeleteCart model);


    }
}
