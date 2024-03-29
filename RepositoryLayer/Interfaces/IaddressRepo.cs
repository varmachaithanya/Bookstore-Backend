using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;

namespace RepositoryLayer.Interfaces
{
    public interface IaddressRepo
    {

        public AddressModel AddAddress(AddressModel model);

        public List<AddressModel> GetAddresses(int userid);


        public AddressModel UpdateAddress(AddressModel model);

    }
}
