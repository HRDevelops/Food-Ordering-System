using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FoodOrderingSystemv1._0
{
    public class Cart
    {
        //private string CartID;
        //private string ProductID;
        //private int ProductQuantity;
        //private long TotalPrice;
        //private long UnitPrice;

       // public string CID;
        public string ID;
        public string Name;
        public string Desc;
        public string Price;
        public string Quantity;
        public string Transfers;
        public string Addres;

        public Cart(string ID, string Name, string Desc, string Price, string Quantity)
        {
           // this.CID = cid;
            this.ID = ID;
            this.Name = Name;
            this.Desc = Desc;
            this.Price = Price;
            this.Quantity = Quantity;
        }

        public Cart(string ID, string Name, string Desc, string Price, string Quantity, string Transfers, string Addres)
        {
            this.ID = ID;
            this.Name = Name;
            this.Desc = Desc;
            this.Price = Price;
            this.Quantity = Quantity;
            this.Transfers = Transfers;
            this.Addres = Addres;
        }
        public Cart(string cartID, string prodID, int prodQuantity, long TPrice, long UPrice)
        {
            CartID = cartID;
            ProductID = prodID;
            ProductQuantity = prodQuantity;
            TotalPrice = TPrice;
            UnitPrice = UPrice;
        }

        public string CartID { get; set; }
        public string ProductID { get; set; }
        public int ProductQuantity { get; set; }
        public long TotalPrice { get; set; }
        public long UnitPrice { get; set; }

        //public Customer SeeCart
        //{
        //    get => default;
        //    set
        //    {
        //    }
        //}

        public void PrintInfo()
        {
            throw new System.NotImplementedException();
        }
    }
}