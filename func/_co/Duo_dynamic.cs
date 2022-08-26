using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Func = nilnul.obj._func.FuncI_dynamic;

namespace nilnul.obj.func._duo
{
	public partial class Duo_dynamic 
	{
		private _func.FuncI_dynamic _func;

		public _func.FuncI_dynamic func
		{
			get { return _func; }
			set { _func = value; }
		}

		private _func.FuncI_dynamic _func1;

		public _func.FuncI_dynamic func1
		{
			get { return _func1; }
			set { _func1 = value; }
		}


		public Duo_dynamic(_func.FuncI_dynamic func, Func func1)
		{
			_func = func;
			_func1 = func1;

		}

	}
}
