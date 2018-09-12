using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceAsType
{
	interface IRelatable
	{
		bool IsLargerThan(IRelatable relatable);
	}
}
