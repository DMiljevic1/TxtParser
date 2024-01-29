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
        protected string Oib { get; set; }
		protected string Name { get; set; }
		protected DateOnly DateOfBirth { get; set; }
		protected Gender Gender { get; set; }
    }
}
