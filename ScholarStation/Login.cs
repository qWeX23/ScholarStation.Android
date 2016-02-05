using System;
using Newtonsoft.Json;
using RestSharp;
using Android.Util;
using System.Threading.Tasks;

namespace ScholarStation
{
	public class Login
	{
		public async Task<object> LoginAsync(string userName, string passWord){
			var client = new RestClient("http://68.1.118.101:3000/LoginApp");
			var req = new RestRequest(Method.POST);
			string user = userName;
			string pass = passWord;
			var loginObject = new LoginRequest {
				username = user,
				password = pass
			};

			var json = req.JsonSerializer.Serialize (loginObject);
			req.AddParameter("application/json; charset=utf-8", json, ParameterType.RequestBody);
			var asd = client.ExecuteAsync(req, response1 => {
				Console.WriteLine(response1.Content);
				 
			});

			return asd;
		}
		/*
		public static object RequestLogin(string userName, string passWord){
			
			var client = new RestClient("http://192.168.1.2/LoginApp");
			var req = new RestRequest(Method.POST);
			string user = userName;
			string pass = passWord;
			var loginObject = new LoginRequest {
				username = user,
				password = pass
			};

			var json = req.JsonSerializer.Serialize (loginObject);
			req.AddParameter("application/json; charset=utf-8", json, ParameterType.RequestBody);
			IRestResponse response = client.Execute(req);

			return response;
		}

*/
		private class LoginRequest{
			public string username { get; set; }
			public string password { get; set; }
			public string RequestType { get; set; }
		}
	
	}

}


