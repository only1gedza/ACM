using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;

namespace ACM.BL
{
    public class Product
    {
        public Product()
        {

        }
        public Product(int productId)
        {
            ProductId = productId;
        }

        public int ProductId { get; private set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal? CurrentPrice { get; set; }

        ///<summary>
        ///Retrieve one Product
        ///</summary>
        public Product Retrieve(int productId)
        {
            // Code that retrives rge defined customer

            return new Product();
        }

        ///<summary>
        ///Saves the current Product
        ///</summary>
        ///<returns></returns>
        public bool Save()
        {
            // Code that saves the defined customer

            return true;
        }

        ///<summary>
        ///Validates the Product data
        ///</summary>
        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrEmpty(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;

            return isValid;
        }
    }
}
