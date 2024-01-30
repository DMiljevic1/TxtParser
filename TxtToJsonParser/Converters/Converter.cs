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
			if (Enum.TryParse<Gender>(value, out Gender gender))
				return gender;
			return null;
		}

		public static DateOnly? ConvertStringToDateOnly(string value)
		{
			if(DateOnly.TryParse(value, out DateOnly dateOnly))
				return dateOnly;
			return null;
		}

		public static decimal? ConvertStringToDecimal(string value)
		{
			if(decimal.TryParse(value, out decimal d))
				return d;
			return null;
		}

		public static double? ConvertStringToDouble(string value)
		{
			if (double.TryParse(value, out double d))
				return d;
			return null;
		}
	}
}
