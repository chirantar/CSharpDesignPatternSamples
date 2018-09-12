using ObservablePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObservablePattern
{
	interface IObservable
	{
		void AddObserver(IObserver o);
		bool RemoveObserver(IObserver o);
		void NotifyObserver();
	}
}
