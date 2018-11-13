﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._5
{
    public class HourlyEmployee : Employee
    {
        private decimal wage;//wage per hour
        private decimal hours;//hours worked for the week

        //five-parameter constructor
        public HourlyEmployee(string firstName, string lastName,
            string socialSecurityNumber, decimal hourlyWage,
            decimal hoursWorked)
            : base(firstName, lastName, socialSecurityNumber)
        {
            wage = hourlyWage;//validate hourly wage
            hours = hoursWorked;//validate hours worked
        }

        //propert that gets and sets hourly employee's wage
        public decimal Wage
        {
            get
            {
                return wage;
            }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                        value, $"{nameof(Wage)} must be >= 0");
                }

                wage = value;
            }
        }

        //property taht gets and sets hourly employee's hours
        public decimal Hours
        {
            get
            {
                return hours;

            }
            set
            {
                if(value < 0 || value > 168)//validation
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                        value, $"{nameof(Hours)} must be >= 0 and <= 168");
                }

                hours = value;
            }
        }

        //calculate earnings; override employee's abstarct method Earnings
        public override decimal Earnings()
        {
            if(Hours <= 40)//no overtime
            {
                return Wage * Hours;
            }
            else
            {
                return (40 * Wage) + ((Hours - 40) * Wage * 1.5M);
            }
        }

        //return string representation of HourlyEmployee object
        public override string ToString() =>
            $"hourly employee: {base.ToString()}\n" +
            $"hourly wage: {Wage:C}\nhours worked: {hours:F2}";
    }
}