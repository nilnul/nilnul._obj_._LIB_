using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.expr_.var
{
	public class SetOfExprs : nilnul.obj.set_.EqDefaulted<expr_.Var, Eq>
	{
		public SetOfExprs()
		{
		}

		public SetOfExprs(params Var[] vars) : base(vars)
		{
		}

		public SetOfExprs(IEnumerable<Var> elements) : base(elements)
		{
		}

		


		public bool has(ParameterExpression varNew)
		{
			return this.Any(v=>v.boxed==varNew);

		//	throw new NotImplementedException();
		}
	}
}
