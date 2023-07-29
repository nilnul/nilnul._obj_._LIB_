using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj._tuple._call
{
	public abstract class Arg1A<T>
	{
		private T _arg1;

		public T arg1
		{
			get { return _arg1; }
			set { _arg1 = value; }
		}
		public Arg1A(T arg)
		{
			_arg1 = arg;
		}
	}
}
