using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj._expr.untyped_.var
{
	[Obsolete()]
	public class Set : nilnul.obj.set_.EqDefaulted<_expr.untyped_.Var, Eq>
	{
		public Set()
		{
		}

		public Set(params Var[] vars) : base(vars)
		{
		}

		public Set(IEnumerable<Var> elements) : base(elements)
		{
		}

		

	}
}
