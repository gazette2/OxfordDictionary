using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using OxfordDictionary.Properties;

namespace OxfordDictionary
{
	public class OxfordDictionary
	{
		private static string url = "https://od-api.oxforddictionaries.com/api/v1/entries/en/";
		private static string appId = Settings.Default.AppID;
		private static string appKey = Settings.Default.AppKey;

		private static DefaultContractResolver contractResolver = new DefaultContractResolver
		{
			NamingStrategy = new CamelCaseNamingStrategy()
		};

		public static RetrieveEntry Lookup(string word)
		{
			HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url + word);
			request.Accept = "application/json";
			request.Headers.Add("app_id", appId);
			request.Headers.Add("app_key", appKey);
			var response = request.GetResponse();

			var stream = response.GetResponseStream();
			var reader = new StreamReader(stream);
			
			string json = reader.ReadToEnd();
			return JsonConvert.DeserializeObject<RetrieveEntry>(json,
				new JsonSerializerSettings {
					ContractResolver = contractResolver,
					NullValueHandling = NullValueHandling.Ignore
				});
		}
	}
}
