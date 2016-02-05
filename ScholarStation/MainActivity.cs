using Android.App;
using Android.Widget;
using Android.OS;
using Android.Util;
using System.Threading.Tasks;

namespace ScholarStation
{
	[Activity (Label = "ScholarStation", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		protected override void OnCreate (Bundle savedInstanceState)
		{
			//string tag = "FUCK";
			//Log.Info(tag, "STUFF WILL HAPPEN");
			base.OnCreate (savedInstanceState);
			string username = "";
			string password = "";
			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Login);

			// Get our button from the layout resource,
			// and attach an event to it
			Button login = FindViewById<Button> (Resource.Id.LoginButton);
			TextView userName = FindViewById<TextView> (Resource.Id.UserName);
			TextView passWord = FindViewById<TextView> (Resource.Id.Password);
			userName.TextChanged += (object sender, Android.Text.TextChangedEventArgs e) => {
				username = e.Text.ToString();
			};

			passWord.TextChanged += (object sender, Android.Text.TextChangedEventArgs e) => {
				password = e.Text.ToString();
			};

			login.Click += async (sender, e) =>  {
				//Error either here or with VM
				try{
					var login_er =new Login();
					Task<object> asdfg =  login_er.LoginAsync(username, password);

					var result = await asdfg;
					string tag = "FUCK";
					Log.Info(tag, "STUFF WILL HAPPEN"+ result.ToString());

				}
				catch (AndroidException){
					
				}

			};

		}
	}
}


