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
    public class UserBusiness:IUserBusiness
    {
        private readonly IUserRepo _userRepo;

        public UserBusiness(IUserRepo userRepo)
        {
            this._userRepo = userRepo;
        }
        public UserModel RegisterUser(UserModel model)
        {
            return _userRepo.RegisterUser(model);
        }

        public object LoginUser(LoginModel model)
        {
            return _userRepo.LoginUser(model);
        }

        public ForgotPasswordModel ForgotPassword(string email)
        {
            return _userRepo.ForgotPassword(email);
        }

        public object GetData()
        {
            return _userRepo.GetData();
        }

        public object UpdateUser(int id, UpdateUser model)
        {
            return _userRepo.UpdateUser(id, model);
        }

        public bool ResetPassword(string email, string password)
        {
            return _userRepo.ResetPassword(email, password);
        }







    }
}
