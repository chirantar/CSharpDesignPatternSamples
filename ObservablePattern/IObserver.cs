using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObservablePattern
{
	public interface IObserver
	{
		void Update(List<String> list);
	}
}
