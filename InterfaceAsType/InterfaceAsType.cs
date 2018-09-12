using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceAsType
{
	class InterfaceAsType
	{
		static void Main(string[] args)
		{
			Rectangle rect = new Rectangle(5, 4);

			IRelatable relatable= new Rectangle(7, 3);

			bool status = rect.IsLargerThan(relatable);
			Console.ReadKey();
		}
	}
}
