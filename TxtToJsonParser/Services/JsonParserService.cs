using DomainModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace TxtToJsonParser.Services
{
	public class JsonParserService
	{
		public static string Serialize(IEnumerable<Person> people)
		{
			return JsonSerializer.Serialize(people);
		}
	}
}
