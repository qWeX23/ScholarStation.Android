using System;
using Newtonsoft.Json;
using RestSharp;

namespace ScholarStation
{
	public static class Login
	{
		
		public static object RequestLogin(){
			string url = "http://www.gooogle.com";
			int port = 3000;

			LoginRequest request = new LoginRequest ("BMP18", "password1");

			var client = new RestClient (url);
			var req = new RestRequest(Method.POST);

			req.AddObject (request);
			client.Execute (req);
			return new object ();
		}

		private class LoginRequest{
			string User, Pass;
			public LoginRequest(string User, string pass){
				this.User=User;
				this.Pass=pass;
			}
		}


	}
}

