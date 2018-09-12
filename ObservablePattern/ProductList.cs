using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObservablePattern
{
	class ProductList : IObservable
	{
		List<String> mProductItems;
		List<IObserver> mObservers = new List<IObserver>();

		public ProductList(List<String> list)
		{
			mProductItems = list;
		}
		public void AddItem(String item)
		{
			mProductItems.Add(item);
			NotifyObserver();
		}
		public bool RemoveItem(String item)
		{
			if (mProductItems.Contains(item))
			{
				mProductItems.Remove(item);
				NotifyObserver();
				return true;
			}
			else
			{
				return false;
			}
		}
			
		public void AddObserver(IObserver o)
		{
			mObservers.Add(o);
		}

		public void NotifyObserver()
		{ 
			foreach(IObserver obs in mObservers)
			{
				obs.Update(mProductItems);
			}
		}

		public bool RemoveObserver(IObserver o)
		{
			if (mObservers.Contains(o))
			{
				mObservers.Remove(o);
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}
