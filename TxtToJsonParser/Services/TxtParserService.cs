using DomainModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TxtToJsonParser.Converters;

namespace TxtToJsonParser.Services
{
	public class TxtParserService
	{
		public static IEnumerable<Person> ParseTxtFile(string filename)
		{
			var result = new List<Person>();
			var fileContent = File.ReadAllText(filename).Trim();
			var rows = fileContent.Split("\n");

			for(int i = 1; i < rows.Length; i++)
			{
				var splittedRow = rows[i].Split(";");
				var oib = splittedRow[1];
				var name = splittedRow[2];
				var gender = Converter.ConvertStringToGender(splittedRow[3]);
				var dateOfBirth = Converter.ConvertStringToDateOnly(splittedRow[4]);
				if (splittedRow[0].Equals("Student"))
				{
					var averageGrade = Converter.ConvertStringToDouble(splittedRow[5]);
					var student = new Student(oib, name, gender, dateOfBirth, averageGrade);
					result.Add(student);
				}
				else if (splittedRow[0].Equals("Professor"))
				{
					var paycheck = Converter.ConvertStringToDecimal(splittedRow[6]);
					var professor = new Professor(oib, name, gender, dateOfBirth, paycheck);
					result.Add(professor);
				}
			}
			return result;
		}
	}
}
