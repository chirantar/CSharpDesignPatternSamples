using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObservablePattern
{
	class ObservableDriver
	{
		static void Main(string[] args)
		{
			List<String> list = new List<string>() { "Hello", "what", "Hey" ,"How"};
			ProductList productList = new ProductList(list);
			ProductObserver1 observer1 = new ProductObserver1(productList);
			observer1.Subscribe();
			ProductObserver2 observer2 = new ProductObserver2(productList);
			observer2.Subscribe();
			productList.AddItem("Hola");
			productList.AddItem("world");
			Console.ReadKey();
		}
	}
}
