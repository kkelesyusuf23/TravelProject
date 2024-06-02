using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json.Linq;

namespace CityTravelProject.BusinessLayer
{
	public class GoogleMapsService
	{
		private readonly HttpClient _httpClient;
		private readonly string _apiKey;

		public GoogleMapsService(HttpClient httpClient, IConfiguration configuration)
		{
			_httpClient = httpClient;
			_apiKey = configuration["GoogleMaps:ApiKey"];
		}

		public async Task<JObject> GetGeocodeAsync(string address)
		{
			var encodedAddress = Uri.EscapeDataString(address);
			var url = $"https://maps.googleapis.com/maps/api/geocode/json?address={encodedAddress}&key={_apiKey}";
			var response = await _httpClient.GetAsync(url);

			if (!response.IsSuccessStatusCode)
			{
				var errorContent = await response.Content.ReadAsStringAsync();
				throw new Exception($"API request failed with status code {response.StatusCode} and content: {errorContent}");
			}

			var content = await response.Content.ReadAsStringAsync();
			return JObject.Parse(content);
		}
	}
}
