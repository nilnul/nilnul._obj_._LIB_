using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.no
{
	public partial class Op<T>
		:tuple.OpI<T>
	{
		private T _val;

		public T val
		{
			get { return _val; }
			set { _val = value; }
		}

		public Op(T val)
		{
			_val = val;
		}

		public T eval() {
			return _val;
		}

		public override string ToString()
		{
			return _val.ToString();
		}
	}
}
