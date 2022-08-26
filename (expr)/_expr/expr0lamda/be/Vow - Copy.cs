using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj._expr._untyped.sys.be
{
	[Obsolete()]

	public class Vow : nilnul.obj.be.Vow4<System.Linq.Expressions.Expression>
		,
		sys.VowI
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
