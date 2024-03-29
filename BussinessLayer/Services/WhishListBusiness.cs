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
    public class WhishListBusiness:IwhishListBusiness
    {
        private readonly IwhishListRepo _whishListRepo;

        public WhishListBusiness(IwhishListRepo whishListRepo)
        {
               this._whishListRepo = whishListRepo;
        }

        public List<Book> AddToWishList(AddWhishlist model)
        {
            return _whishListRepo.AddToWishList(model);    
        }

        public List<Book> GetWhishListBooks(int userid)
        {
            return _whishListRepo.GetWhishListBooks(userid);
        }

        public bool DeleteWhishlist(DeleteCart model)
        {
            return _whishListRepo.DeleteWhishlist(model);
        }


    }
}
