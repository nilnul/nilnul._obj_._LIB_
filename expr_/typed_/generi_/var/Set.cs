using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.expr_.typed_.generi_.var
{
	public class Set<T> : nilnul.obj.set_.EqDefaulted<Var<T>, Eq<T>>
	{
		public Set()
		{
		}

		public Set(params Var<T>[] vars) : base(vars)
		{
		}

		public Set(IEnumerable<Var<T>> elements) : base(elements)
		{
		}

		
	}
}
