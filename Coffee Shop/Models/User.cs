using System;
namespace Coffee_Shop.Models
{
	public class User
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }
		public string password { get; set; }
		public string Flavor { get; set; }
		public bool Lactose { get; set; }
	}
}

