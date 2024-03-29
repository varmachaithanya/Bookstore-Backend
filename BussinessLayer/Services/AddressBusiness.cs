using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessLayer.Interfaces;
using ModelLayer;
using RepositoryLayer.Interfaces;

namespace BussinessLayer.Services
{
    public class AddressBusiness:IaddressBusiness
    {
        private readonly IaddressRepo _addressRepo;

        public AddressBusiness(IaddressRepo addressRepo)
        {
            _addressRepo = addressRepo;
        }

        public AddressModel AddAddress(AddressModel model)
        {
            return _addressRepo.AddAddress(model);
        }

        public List<AddressModel> GetAddresses(int userid)
        {
            return _addressRepo.GetAddresses(userid);

        }

        public AddressModel UpdateAddress(AddressModel model)
        {
            return _addressRepo.UpdateAddress(model);
        }



    }
}
