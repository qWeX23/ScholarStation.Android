using Android.App;
using Android.Widget;
using Android.OS;
using Android.Util;
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
			login.Click += delegate(object sender, System.EventArgs e) {
				//Error either here or with VM
				try{
				Login.RequestLogin (username, password);
				}
				catch{
					
				}

			};
			string tag = "FUCK";
			Log.Info(tag, "STUFF WILL HAPPEN");
		}

	}
}


