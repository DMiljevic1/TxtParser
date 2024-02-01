using DomainModels.Models;
using TxtToJsonParser.Services;

namespace TxtParser.TxtToJsonParser
{
	public class Program
	{
		static void Main(string[] args)
		{
			var txtFilePath = "C:\\Users\\dujem\\OneDrive\\Documents\\TxtFile.txt";                                 // enter path to your text file
			var jsonFilePath = "C:\\Users\\dujem\\OneDrive\\Documents\\TxtFileInJson.json";							// enter path to your json file
			var people = TxtParserService.ParseTxtFile(txtFilePath);

			if(people.Any())
			{
				var json = JsonParserService.Serialize(people);
				File.WriteAllTextAsync(jsonFilePath, json);
			}
		}
	}
}
