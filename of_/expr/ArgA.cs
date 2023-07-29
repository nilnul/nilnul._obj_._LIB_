using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.op.expr
{
	public partial class ArgA<T>
	{
		private T _arg;

		public T arg
		{
			get { return _arg; }
			set { _arg = value; }
		}

		public ArgA(T arg)
		{
			this._arg = arg;

		}
		
	}
}
