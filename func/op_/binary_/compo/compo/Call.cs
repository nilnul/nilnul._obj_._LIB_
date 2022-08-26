using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.func.op.compo
{
	public partial class Call<TFunc,TFunc1>

	{
		private TFunc _func;

		public TFunc func
		{
			get { return _func; }
			set { _func = value; }
		}

		private TFunc1 _func1;

		public TFunc1 func1
		{
			get { return _func1; }
			set { _func1 = value; }
		}


		
		

	}
}
