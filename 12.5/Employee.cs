using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._5
{
    public abstract class Employee
    {
        public string FirstName { get; }
        public string LastName { get; }
        public string SocialSecurityNumber { get; }

        //three-parameter constructor
        public Employee(string firstName,string lastName,
            string socialSecurityNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            SocialSecurityNumber = socialSecurityNumber;
        }

        //return string representation of Employee object, suing properties
        public override string ToString() => $"{FirstName} {LastName}\n" +
            $"social security number: {SocialSecurityNumber}";

        //abstract method overriden by derived classes
        public abstract decimal Earnings();//no implementation here
    }
}
