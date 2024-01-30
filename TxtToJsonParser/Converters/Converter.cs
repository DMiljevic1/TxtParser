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
		public static Gender? ConvertStringToGender(string value)
		{
			if(Enum.TryParse<Gender>(value, out Gender gender))
				return gender;
			return null;
		}

		public static DateOnly? ConvertStringToDateOnly(string value)
		{
			try
			{
				DateOnly date = DateOnly.Parse(value);
				return date;
			}
			catch (Exception e)
			{
                Console.WriteLine(e);
				return null;
            }
		}

		public static Decimal? ConvertStringToDecimal(string value)
		{
			try
			{
				return Convert.ToDecimal(value);
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				return null;
			}
		}

		public static Double? ConvertStringToDouble(string value)
		{
			try
			{
				return ConvertStringToDouble(value);
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				return null;
			}
		}
	}
}
