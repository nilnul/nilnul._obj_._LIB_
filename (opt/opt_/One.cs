using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.opt_
{
	public class One<T>:OptI<T>,OneI
	{
		private T _val;

		public T val
		{
			get { return _val; }
			set { _val = value; }
		}

		public One(T val)
		{
			_val = val;
		}
		public override string ToString()
		{
			return _val.ToString();
		}
	}
}
