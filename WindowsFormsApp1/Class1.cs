using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
	class Class1
	{
		public string View { get; private set; }
		public int Liter { get; private set; }
		public int Date { get; private set; }

		public Class1(string view, int liter, int date)
		{
			View = view;
			Liter = liter;
			Date = date;
		}

		public override string ToString()
		{
			return View;
		}
	}
   }