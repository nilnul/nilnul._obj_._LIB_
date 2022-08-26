using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.expr_.var
{
	public class Set : nilnul.obj.set_.EqDefaulted<expr_.VarI, Eq>
	{
		public Set()
		{
		}

		public Set(params VarI[] vars) : base(vars)
		{
		}

		public Set(IEnumerable<VarI> elements) : base(elements)
		{
		}

		


		public bool has(ParameterExpression varNew)
		{
			return this.Any(v=>v.sys==varNew);
		//	throw new NotImplementedException();
		}
	}
}
