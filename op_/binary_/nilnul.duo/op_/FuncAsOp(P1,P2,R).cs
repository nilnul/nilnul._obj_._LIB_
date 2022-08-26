using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.duo
{
	public partial class FuncAsOp<P1,P2,R>
		:OpI<P1,P2,R>
	{

		private Func<P1,P2,R> _func;

		public Func<P1,P2,R> func
		{
			get { return _func; }
			set { _func = value; }
		}


		
		public FuncAsOp(Func<P1,P2,R> func)
		{
			_func = func;
		}

		public R eval(P1 a, P2 b)
		{
			return _func(a, b);
			throw new NotImplementedException();
		}

		public override string ToString()
		{
			return NamingContext.Name(this)??base.ToString();
		}
	}
}
