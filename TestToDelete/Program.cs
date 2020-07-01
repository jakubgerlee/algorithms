using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TestToDelete
{
	class Program
	{
		static void Main(string[] args)
		{
			var devices =  AvgRotorSpeed("RUNNING", 2);
			Console.ReadKey();
		}

		public static async Task<int> AvgRotorSpeed(string statusQuery, int parentId)
		{
			var operatingParams = await GetOperatingParams(statusQuery, parentId);
			var array = operatingParams as int[] ?? operatingParams.ToArray();
			var sum = array.Sum();
			var countOfRotorSpeed = array.Count();
			return sum / countOfRotorSpeed;

		}

		public static async Task<IEnumerable<int>> GetOperatingParams(string statusQuery, int parentId)
		{
			var iotDevices = await GetRotorSpeedsFromResource(statusQuery, parentId);
			return iotDevices.Devices.Select(x => x.OperatingParams.RotorSpeed);

		}

		private static async Task<IotDevices> GetRotorSpeedsFromResource(string statusQuery, int parentId)
		{
			try
			{
				using var httpClient = new HttpClient();
				using var response = await httpClient.GetAsync($"https://jsonmock.hackerrank.com/api/iot_devices?status={statusQuery}&page={parentId}");
				var apiResponse = await response.Content.ReadAsStringAsync();
				return JsonConvert.DeserializeObject<IotDevices>(apiResponse);
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				throw;
			}
		}
	}
}

class IotDevices
{

	[JsonProperty(PropertyName = "data")]
	public List<Device> Devices { get; set; }

}

public class Device
{

	[JsonPropertyName("operatingParams")]
	public OperatingParams OperatingParams { get; set; }

}

public class OperatingParams
{
	public int RotorSpeed { get; set; }
}
