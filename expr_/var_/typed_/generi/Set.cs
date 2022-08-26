using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.expr_.var
{
	[Obsolete(nameof(expr_.typed_.generi_.var.Set<T>))]
	public class Set<T> : nilnul.obj.set_.EqDefaulted<expr_.Var_sys<T>, Eq<T>>
	{
		public Set()
		{
		}

		public Set(params Var_sys<T>[] vars) : base(vars)
		{
		}

		public Set(IEnumerable<Var_sys<T>> elements) : base(elements)
		{
		}

	
	}
}
