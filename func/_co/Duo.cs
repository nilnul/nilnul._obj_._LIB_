using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Func = nilnul.obj._func.FuncI_dynamic;

namespace nilnul.obj.func._duo
{
	public partial class Duo 
	{
		private Func _func;

		public Func func
		{
			get { return _func; }
			set { _func = value; }
		}

		private Func _func1;

		public Func func1
		{
			get { return _func1; }
			set { _func1 = value; }
		}


		public Duo(Func func, Func func1)
		{
			_func = func;
			_func1 = func1;

		}

	}
}
