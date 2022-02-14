using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace FoodOrderingSystemv1._0
{
    public class Product
    {
        //private string ProductID;
        //private string ProductName;
        //private Image ProductImage;
        //private string ProductDescription;
        //private double ProductPrice;

        public Product(string productID,string ProName, string proDesc,long proPrice,Image proImage)
        {
            ProductID = productID;
            ProductName = ProName;
            ProductImage= proImage;
            ProductDescription = proDesc;
            ProductPrice = proPrice;
        }

        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public Image ProductImage { get; set; }
        public string ProductDescription { get; set; }
        public double ProductPrice { get; set; }

        public Product(string id, string name, string desc,double price)
        {
            ProductID = id;
            ProductName = name;
            ProductDescription = desc;
            ProductPrice = price;
        }
        public void PrintInfo()
        {
            throw new System.NotImplementedException();
        }
    }
}