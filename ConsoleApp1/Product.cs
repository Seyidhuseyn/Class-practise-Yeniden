using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Product
    {
		private string _name;
        private int _price;

        public string Name
		{
			get { return _name; }
			set { _name = value; }
		}
		public int Price
		{
			get { return _price; }
			set { _price = value; }
		}
	}
}
