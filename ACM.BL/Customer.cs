using System;
using System.Collections.Generic;

namespace ACM.BL
{
    public class Customer
    {
        public int CustomerId { get; private set; }
        public string LastName { get; set; }

        public string FirstName { get; set; }

        public string EmailAddress { get; set; }

        public string FullName
        {
            get
            {
                string fullName = LastName;
                if (!string.IsNullOrEmpty(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }
        }

        public static int InstanceCount { get; set; }


        ///<summary>
        ///Retrieve one customer
        ///</summary>
        public Customer Retrieve(int customerId)
        {
            // Code that retrives rge defined customer

            return new Customer();
        }

        ///<summary>
        ///Saves the current customer
        ///</summary>
        ///<returns></returns>
        public bool Save()
        {
            // Code that saves the defined customer

            return true;
        }

        ///<summary>
        ///Retrieve all customers 
        ///</summary>
        public List<Customer> Retrieve()
        {
            // Code that retrieves all of the customers

            return new List<Customer>();
        }

        ///<summary>
        ///Validates the customer data
        ///</summary>
        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrEmpty(LastName)) isValid = false;
            if (string.IsNullOrEmpty(EmailAddress)) isValid = false;

            return isValid;
        }
    }
}
