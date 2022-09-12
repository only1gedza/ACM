using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class OrderItem
    {
        public OrderItem()
        {

        }
        public OrderItem(int orderItemId)
        {
            OrderItemId = orderItemId;
        }


        public int OrderItemId { get; private set; }
        public int Quantity { get; set; }
        public int ProductId { get; set; }
        public decimal? PurchasePrice { get; set; }

        ///<summary>
        ///Retrieve one orderItem
        ///</summary>
        public OrderItem Retrieve(int orderItemId)
        {
            // Code that retrives the defined customer

            return new OrderItem();
        }

        ///<summary>
        ///Saves the current Order
        ///</summary>
        ///<returns></returns>
        public bool Save()
        {
            // Code that saves the defined customer

            return true;
        }

        ///<summary>
        ///Validates the Order data
        ///</summary>
        public bool Validate()
        {
            var isValid = true;
            
            if (Quantity <= 0) isValid = false;
            if (ProductId <= 0) isValid = false;
            if (PurchasePrice == null) isValid = false;

            return isValid;
        }
    }
}

