using Android.App;
using Android.Widget;
using Android.OS;

namespace ScholarStation
{
	[Activity (Label = "ScholarStation", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		int count = 1;

		protected override void OnCreate (Bundle savedInstanceState)
		{
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
				Login.RequestLogin (username, password);
			};	
		}
	}
}


