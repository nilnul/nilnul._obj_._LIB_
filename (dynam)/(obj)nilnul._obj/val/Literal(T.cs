using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.val
{
	public partial class Literal< T>
		:LiteralI<T>
	{
		private T _val;

		public T val
		{
			get { return _val; }
			set { _val = value; }
		}
		

		public Literal(T val)
		{
			_val = val;
		}
	}
}
