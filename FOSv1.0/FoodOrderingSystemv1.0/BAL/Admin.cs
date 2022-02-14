using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FoodOrderingSystemv1._0
{
    public class Admin : Person
    {
        public Admin(int id, string name, string address, long cellNo, string password) : base(id, name, address, cellNo, password)
        {
            
        }

        public void Products()
        {
            throw new System.NotImplementedException();
        }
    }
}