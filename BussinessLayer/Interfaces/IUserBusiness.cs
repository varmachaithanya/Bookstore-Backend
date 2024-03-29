using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;
using RepositoryLayer.Entity;

namespace BussinessLayer.Interfaces
{
    public interface IUserBusiness
    {
        public UserModel RegisterUser(UserModel model);

        public object LoginUser(LoginModel model);


        public ForgotPasswordModel ForgotPassword(string email);

        public object GetData();

        public object UpdateUser(int id, UpdateUser model);

        public bool ResetPassword(string email, string password);





    }
}
