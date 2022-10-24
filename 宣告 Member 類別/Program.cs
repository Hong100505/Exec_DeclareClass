using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace 宣告_Member_類別
{
	internal class Program
	{
		static void Main(string[] args)
		{
		}
	}
	class Member
	{
		public string Name { get; set; }
		public string Account { get; set; }
		public string Password { get; set; }
		public string Email { get; set; }
		public string Addres { get; set; }
		public string Cellphone { get; set; }
		public string Telephone { get; set; }

		

		public void Register(string Name, string Accout, string Passord, string ConfirmPassword, string email)
		{

		}

		public void ForgetPassword(string Name, string Email)
		{

		}
		public void Authenticate(string Name, string Email)
		{


		}
	}
}
