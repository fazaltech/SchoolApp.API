using System;

namespace SchoolApp.API.Data.ViewModels
{
	public class AuthResultVM
	{
        public string Token { get; set; }

		public DateTime ExpiresAt { get; set; }
    }
}
