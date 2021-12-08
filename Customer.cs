using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LouigisSP.BO
{
    public class Customer : Person
    {

        string shippingAddress;
        string billingAddress;
        

        public Customer() : base()
        {

        }


        public string ShippingAddress { get => shippingAddress; set => shippingAddress = value; }
        public string BillingAddress { get => billingAddress; set => billingAddress = value; }

        //for ocassons when all parameters are recieved
        public Customer(int id, string firstName, string lastName, string phoneNumber, string email, string pass, DateTime dateOfRegistration, DateTime dateOfBirth, string shippingAddress, string billingAddress ) : base(id, firstName, lastName, phoneNumber, email, pass, dateOfRegistration, dateOfBirth)
        {
            this.shippingAddress = shippingAddress;
            this.billingAddress = billingAddress;
           

        }
       
       
    }
}
