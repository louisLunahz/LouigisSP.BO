using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LouigisSP.BO
{
    public class Employee : Person
    {

        public Employee(): base() { 
        
        }

        public Employee(int id, string firstName, string lastName, string phoneNumber, string email, string pass, DateTime dateOfRegistration, DateTime dateOfBirth ) : base(id, firstName, lastName, phoneNumber, email, pass, dateOfRegistration, dateOfBirth)
        {

        }



        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
