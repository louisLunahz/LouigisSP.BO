using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LouigisSP.BO
{
    public class Admin : Employee
    {
        public Admin()
        {

        }

        public Admin(int id, string firstName, string lastName, string phoneNumber, string email, string pass, DateTime dateOfRegistration, DateTime dateOfBirth) : base(id, firstName, lastName, phoneNumber, email, pass, dateOfRegistration, dateOfBirth)
        {

        }
    }
}
