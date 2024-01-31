using DomainModels.Models;
using TxtToJsonParser.Services;

namespace TxtParser.TxtToJsonParser
{
	public class Program
	{
		static void Main(string[] args)
		{
			var persons = TxtParserService.ParseTxtFile("C:\\Users\\dujem\\OneDrive\\Documents\\TxtFile.txt");
			foreach (var person in persons)
			{
				if (person is Student)
				{
					var student = (Student)person;
					WritePersonProperties(student);
					Console.WriteLine(student.AverageGrade);
				}
				else if (person is Professor)
				{
					var professor = (Professor)person;
					WritePersonProperties(professor);
					Console.WriteLine(professor.Paycheck);
				}
				Console.WriteLine("----------------");
			}
		}

		private static void WritePersonProperties(Person person)
		{
			Console.WriteLine(person.Oib);
			Console.WriteLine(person.Name);
			Console.WriteLine(person.Gender);
			Console.WriteLine(person.DateOfBirth);
		}
	}
}
