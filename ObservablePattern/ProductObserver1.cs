using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObservablePattern
{
	class ProductObserver1 : IObserver
	{
		List<String> mItemList;
		IObservable mObservalble;
		public ProductObserver1(IObservable observable)
		{
			mItemList = new List<String>();
			mObservalble = observable;
		}
		private void PrintAllItems()
		{
			foreach(string item in mItemList)
			{
				Console.WriteLine(this.GetType().Name + ": " + item);
			}
		}
		public void Update(List<String> list)
		{
			mItemList = list;
			Console.WriteLine("Notified" + this.GetType().Name);
		}
		public void Unsubscribe()
		{
			mObservalble.RemoveObserver(this);
		}
		public void Subscribe()
		{
			mObservalble.AddObserver(this);
		}
	}
}
