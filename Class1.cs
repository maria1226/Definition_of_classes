using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class Products
    {   //fields

        private string productName;
        private string unitOfMeasure;
        private int quantity;
        private double wholesalePrice;

        //Properties

        public string ProductName
        {
            get
            {
                return productName;
            }
            set
            {
                productName = value;
            }
        }
        public string UnitOfMeasure
        {
            get
            {
                return unitOfMeasure;
            }
            set
            {
                unitOfMeasure = value;
            }

        }
        public int Quantity {
            get
            {
                return quantity;
            }
            set
            {
                quantity = value;
            }
            
        }
        public double WholesalePrice
        {
            get 
            {
                return wholesalePrice;
            }
            set 
            {
                wholesalePrice = value;
            }
        }

        //default constructor
        public Products()
        {
            productName = "milk";
            unitOfMeasure = "litars";
            quantity = 2;
            wholesalePrice = 3.00;
        }
        //second constructor
        public Products(string productName):this()
        {
            this.productName = productName;
        }

        //third constructor

        public Products(string productName,int quantity):this()
        {
            this.productName = productName;
            this.quantity = quantity;
        }
        //Method that calculates the retail price for this product
        public double retailPrice()
        {
           return wholesalePrice + 0.2 * wholesalePrice;
        }

    }
}
