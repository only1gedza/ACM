using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class Order
    {
        public Order()
        {

        }
        public Order(int orderId)
        {
            OrderId = orderId;
        }

        public DateTimeOffset? OrderDate { get; set; }
        public int OrderId { get; private set; }
        ///<summary>
        ///Retrieve one order
        ///</summary>
        public Order Retrieve(int orderId)
        {
            // Code that retrives the defined Order

            return new Order();
        }

        ///<summary>
        ///Saves the current Order
        ///</summary>
        ///<returns></returns>
        public bool Save()
        {
            // Code that saves the defined Order

            return true;
        }

        ///<summary>
        ///Validates the Order data
        ///</summary>
        public bool Validate()
        {
            var isValid = true;

            if (OrderDate == null) isValid = false;

            return isValid;
        }
    }
}
