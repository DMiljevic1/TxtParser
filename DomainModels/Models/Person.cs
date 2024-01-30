using DomainModels.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModels.Models
{
	public abstract class Person
	{
        public string Oib { get; set; }
		public string Name { get; set; }
		public DateOnly DateOfBirth { get; set; }
		public Gender Gender { get; set; }

		protected Person(string oib, string name, DateOnly dateOfBirth, Gender gender) 
		{
			Oib = oib;
			Name = name;
			DateOfBirth = dateOfBirth;
			Gender = gender;
		}

		protected Person() { }
    }
}
