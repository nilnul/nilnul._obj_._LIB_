using nilnul.obj._func;
using nilnul.obj._func.untyped.be_.ofType_.typed.vow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj
{
	public interface FuncI2<T>
	{
		obj._func.untyped.be_.ofType_.typed.vow.Ee<T> untyped { get; }
	}

	public class Func2<T> :
		obj._func.untyped.be_.ofType_.typed.vow.Ee<T>
		,
		FuncI2<T>
	{
		public Func2(UntypedI val) : base(val)
		{
		}

		public Func2(Untyped val) : base(val)
		{
		}

		public Func2(Expression x) : base(x)
		{
		}

		public Ee<T> untyped => this;
	}
}
