using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class User
    {
		private string _username;
        private string _password;
        private bool _issignedin;
        private Product[] _products;

        public string Username
		{
			get { return _username; }
			set 
			{
				if (value.Length>6 && value.Length<25)
				{
				_username = value; 
				}
				else
				{
					Console.WriteLine("Adi duzgun daxil edin!");
				}
			}
		}
		public string Password
		{
			get { return _password; }
            set
            {
                if (value.Length > 8 && value.Length < 25)
                {
                    _password = value;
                }
                else
                {
                    Console.WriteLine("Parolu duzgun daxil edin!");
                }
            }
        }
		public bool Issignedin
		{
			get { return _issignedin; }
			set { _issignedin = value; }
		}
		public Product[] Products
		{
			get { return _products; }
			set { _products = value; }
		}
		public User(string username, string password)
		{
			_username = username;
			_password = password;
		}

		public bool CheckPassword(string password)
		{
			for (int i = 0; i < password.Length; i++)
			{
				if (char.IsUpper(password[i]) && char.IsDigit(password[i]))
				{
					return true;
				}
			}
			return false;
		}
		public void Login()
		{
			string _username  = Console.ReadLine();
			string _password = Console.ReadLine();
			if (_username == Username && _password == Password)
			{
				Issignedin= true;
			}
		}
		public void Add(Product products)
		{
			if (Issignedin=true)
			{
				Array.Resize(ref _products, _products.Length + 1);
				_products[_products.Length-1] = products;
			}
			else
			{

			}
		}
	}
}
