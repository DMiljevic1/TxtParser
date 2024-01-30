using DomainModels.Models;
using TxtToJsonParser.Services;

var persons = TxtParserService.ParseTxtFile("C:\\Users\\dujem\\OneDrive\\Documents\\TxtFile.txt");
foreach (var person in persons)
{
	Console.WriteLine(person.Oib);
	Console.WriteLine(person.Name);
	Console.WriteLine(person.Gender);
	Console.WriteLine(person.DateOfBirth);
	Console.WriteLine("----------------");
}
