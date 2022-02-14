using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace FoodOrderingSystemv1._0
{
    public class Menu : Product
    {
        //private string MenuID;

        public Menu(string menuID, string productID, string ProName, string proDesc, long proPrice):base(productID, ProName,  proDesc,proPrice)
        {
            MenuID = menuID;
        }



        public Customer SeeMenu
        {
            get => default;
            set
            {
            }
        }

        public string MenuID { get; set; }

        public void PrintInfo()
        {
            throw new System.NotImplementedException();
        }
    }
}