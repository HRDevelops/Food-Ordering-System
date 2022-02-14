using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FoodOrderingSystemv1._0
{
    public class Order
    {
        private string OrderID;
        private string ProductID;
        private long UnitPrice1;
        private int quantity;
        private long TotalPrice;
        public long UnitPrice { get { return UnitPrice1; } set { UnitPrice1 = value; } }
        public int Quantity { get { return quantity; } set { quantity = value; } }
        public Order(int quantity)
        {
            //UnitPrice = unitprice;
            Quantity = quantity;
        }

        public Employee SeeEmpOrder
        {
            get => default;
            set
            {
            }
        }

        public Cart AddOrder
        {
            get => default;
            set
            {
            }
        }

        public void PrintInfo()
        {
            throw new System.NotImplementedException();
        }
    }
}