using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.call
{
	public partial class Literal<T>
		:CallI<T>
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
		public T eval()
		{
			return _val;
			throw new NotImplementedException();
		}
		public override string ToString()
		{
			return _val.ToString();
		}
	}
}
