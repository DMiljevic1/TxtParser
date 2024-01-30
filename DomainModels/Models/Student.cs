using DomainModels.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModels.Models
{
	public class Student : Person
	{
        public double AverageGrade { get; set; }

		public Student(string oib, string name, DateOnly dateOfBirth, Gender gender, double averageGrade) : base (oib, name, dateOfBirth, gender)
		{
			AverageGrade = averageGrade;
		}

		public Student() { }
    }
}
