using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj._tuple._call
{
	public abstract class ArgA<T>
	{
		private T _arg;

		public T arg
		{
			get { return _arg; }
			set { _arg = value; }
		}
		public ArgA(T arg)
		{
			_arg = arg;
		}
	}
}
