using DomainModels.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TxtToJsonParser.Converters
{
	public class Converter
	{
		public static Gender ConvertStringToGender(string value)
		{
			try
			{
				if (Enum.TryParse<Gender>(value, out Gender gender))
				{
					return gender;
				}
				throw new ArgumentException("Invalid gender value: " + value);
			}
			catch (Exception e)
			{
                Console.WriteLine("Error converting string to gender: " + e);
                throw;
			}

		}

		public static DateOnly ConvertStringToDateOnly(string value)
		{
			try
			{
				return DateOnly.Parse(value);

				throw new ArgumentException("Invalid date value: " + value);
			}
			catch (Exception e)
			{
				Console.WriteLine("Error converting string to dateOnly: " + e);
				throw;
			}
		}

		public static Decimal ConvertStringToDecimal(string value)
		{
			try
			{
				return Convert.ToDecimal(value);

				throw new ArgumentException("Invalid decimal value: " + value);
			}
			catch (Exception e)
			{
				Console.WriteLine("Error converting string to decimal: " + e);
				throw;
			}
		}

		public static Double ConvertStringToDouble(string value)
		{
			try
			{
				return Convert.ToDouble(value);

				throw new ArgumentException("Invalid double value: " + value);
			}
			catch (Exception e)
			{
				Console.WriteLine("Error converting string to double: " + e);
				throw;
			}
		}
	}
}
