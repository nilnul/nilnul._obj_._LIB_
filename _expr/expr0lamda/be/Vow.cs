using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj._expr.expr0lamda.be
{
	public class Vow : nilnul.obj.be.Vow4<System.Linq.Expressions.Expression>
		,
		expr0lamda.VowI
	{
		public Vow(BeI1<Expression> be) : base(be)
		{
		}

		public Vow(Predicate<Expression> predicate) : base(predicate)
		{
		}

		public Vow(Func<Expression, bool> func) : base(func)
		{
		}
	}
}
