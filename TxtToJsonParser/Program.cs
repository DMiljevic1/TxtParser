using DomainModels.Models;
using TxtToJsonParser.Services;

namespace TxtParser.TxtToJsonParser
{
	public class Program
	{
		static void Main(string[] args)
		{
			var people = TxtParserService.ParseTxtFile("C:\\Users\\dujem\\OneDrive\\Documents\\TxtFile.txt");
			foreach (var person in people)
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
			if(people.Any())
			{
				var json = JsonParserService.Serialize(people);
				File.WriteAllTextAsync("C:\\Users\\dujem\\OneDrive\\Documents\\TxtFileInJson.json", json);
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
