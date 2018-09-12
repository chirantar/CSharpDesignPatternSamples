using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceAsType
{
	class Rectangle : IRelatable
	{
		private int mWidth;
		private int mHeight;
		public Rectangle(int w, int h)
		{
			mWidth = w;
			mHeight = h;
		}
		public int GetArea()
		{
			return mWidth * mHeight;
		}
		public bool IsLargerThan(IRelatable relatable)
		{
			Rectangle obj = (Rectangle)relatable;
			return this.GetArea() > obj.GetArea();
		}
	}
}
