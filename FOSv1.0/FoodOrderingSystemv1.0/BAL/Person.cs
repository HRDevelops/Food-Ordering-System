using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FoodOrderingSystemv1._0
{
    public class Person
    {
        //private int ID;
        //private string Name;
        //private string Address;
        //private long CellNo;
        //private string Password;
        public Person()
        {

        }
        public Person(int id, string name, string address, long cellNo, string password)
        {
            ID = id;
            Name = name;
            Address = address;
            CellNo = cellNo;
            Password = password;
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public long CellNo { get; set; }
        public string Password { get; set; }

        public void Login()
        {
            throw new System.NotImplementedException();
        }

        public void PrintInfo()
        {
            throw new System.NotImplementedException();
        }
    }
}