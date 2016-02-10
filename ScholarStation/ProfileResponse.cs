using System;

namespace ScholarStation
{
	public class ProfileResponse
	{
		public string fname{get;set;}
		public string lname{get;set;}
		public string major{get;set;}
		public string email{get;set;}
		public string gender{get;set;}
		public string year{get;set;}
		public int age{get;set;}

		public override string ToString ()
		{
			return string.Format ("@string/ProfileResponse", fname, lname, major, email, gender, year, age);
		}


	}
}

