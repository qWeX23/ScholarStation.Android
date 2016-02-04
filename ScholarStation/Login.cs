using System;
using Newtonsoft.Json;
using RestSharp;
using Android.Util;
namespace ScholarStation
{
	public static class Login
	{
		
		public static object RequestLogin(string userName, string passWord){
			
			var client = new RestClient("http://192.168.1.12/LoginApp");
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


			//Console.ReadKey();

			return response;
		}
				private class LoginRequest{
					public string username { get; set; }
					public string password { get; set; }
					public string RequestType { get; set; }
				}
	
	}

}


