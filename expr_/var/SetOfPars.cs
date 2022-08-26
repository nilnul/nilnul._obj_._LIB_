using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using P = System.Linq.Expressions.ParameterExpression;

namespace nilnul.obj.expr_.var
{
	public class SetOfVars : nilnul.obj.set_.EqDefaulted<ParameterExpression, Eq>
	{
		

		public SetOfVars(params ParameterExpression[] vars) : base(vars)
		{
		}

		public SetOfVars(IEnumerable<P> elements) : base(elements)
		{
		}

		public SetOfVars() : base()
		{
		}

		public SetOfVars(IEnumerable<P> collection, IEqualityComparer<P> comparer) : base(collection)
		{
		}

		
	}
}
