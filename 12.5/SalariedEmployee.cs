﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._5
{
    class SalariedEmployee : Employee
    {
        private decimal weeklySalary;

        //four-parameter constructor
        public SalariedEmployee(string firstName, string lastName,
            string socialSecurityNumber, decimal weeklySalary)
            :base(firstName,lastName,socialSecurityNumber)
        {
            WeeklySalary = weeklySalary;
        }

        //property taht gets and sets salaried employee's salary
        public decimal WeeklySalary
        {
            get
            {
                return weeklySalary;
            }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                        value, $"{nameof(WeeklySalary)} must be >= 0");
                }

                weeklySalary = value;
            }
        }

        //calculate earnings; override abstract method Earnings in Employee
        public override decimal Earnings() => weeklySalary;

        //return string representation of Salariedemployee object 
        public override string ToString() =>
            $"salaried employee: {base.ToString()}\n" +
            $"weekly salary: {WeeklySalary:c}";  
    }
}