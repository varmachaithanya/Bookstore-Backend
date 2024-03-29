﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;
using RepositoryLayer.Entity;

namespace BussinessLayer.Interfaces
{
    public interface IorderBusiness
    {
        public List<Book> AddToOrder(OrderModel model, int userid);

        public List<Book> GetOrders(int userid);


        public double GetPriceInOrder(int userid);



    }
}
