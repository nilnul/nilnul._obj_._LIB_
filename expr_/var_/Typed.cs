using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj._expr.untyped_.var_
{



	[Obsolete()]
	public class Typed<T> :
		Var
		
		
		

	{
		

		
		public Typed():base(
			Expression.Parameter(typeof(T) )
		)
		{

		}
		public Typed(string s):base(
			Expression.Parameter(typeof(T), s)
		)
		{

		}


	}
}
