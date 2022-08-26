using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj._func.untyped.be_.ofType_.typed.vow
{
	public class Ee<T> :
		nilnul.obj.vow.ee_.Defaultable<
			UntypedI,
			typed.Vow<T>
		>
	{
		public Ee(UntypedI val) : base(val)
		{
		}
		public Ee(Untyped val) : base(val)
		{
		}

		public Ee(Expression x):this(new Untyped(x))
		{

		}
	}
}
