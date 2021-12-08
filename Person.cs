using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LouigisSP.BO
{
   public  abstract class Person
    {   
         int id;
        string firstName;
        string lastName;
        string phoneNumber;
        string email;
        string pass;
        DateTime dateOfRegistration;
        DateTime dateOfBirth;
       
       
        

        public Person(int id, string firstName, string lastName, string phoneNumber, string email, string pass, DateTime dateOfRegistration, DateTime dateOfBirth)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.phoneNumber = phoneNumber;
            this.email = email;
            this.pass = pass;
            this.DateOfRegistration = dateOfRegistration;
            this.DateOfBirth = dateOfBirth;
          
        }
     

       

        public Person() { 
        
        }


        public int Id { get => id; set => id = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Email { get => email; set => email = value; }
        public string Pass { get => pass; set => pass = value; }
        public DateTime DateOfRegistration { get => dateOfRegistration; set => dateOfRegistration = value; }
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }

        public int CompareTo(object obj)
        {
            Person obj_user = (Person)obj;
            return this.Email.CompareTo(obj_user.Email);
        }


        public override string ToString()
        {
            return string.Format("{0,15} {1,15} {2,15} {3,15}", id, firstName, lastName, Email);
        }


        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Person))
            {
                return false;
            }
            else
            {
                return this.firstName == ((Person)obj).firstName;
            }
        }

    }
}
