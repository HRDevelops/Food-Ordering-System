using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FoodOrderingSystemv1._0
{
    public class Customer : Person
    {
        public Customer()
        {

        }
        public Customer(int id, string name, string address, long cellNo, string password) :base(id, name, address, cellNo, password)
        {
            //throw new System.NotImplementedException();
        }
    }
}