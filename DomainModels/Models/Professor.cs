using DomainModels.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModels.Models
{
	public class Professor : Person
	{
        public decimal Paycheck { get; set; }
		public Professor(string oib, string name, DateOnly dateOfBirth, Gender gender, decimal paycheck) : base(oib, name, dateOfBirth, gender)
		{
			Paycheck = paycheck;
		}

		public Professor() { }
    }
}
