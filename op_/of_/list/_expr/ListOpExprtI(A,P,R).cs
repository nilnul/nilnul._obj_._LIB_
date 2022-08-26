using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul_obj.op
{
	public interface ListOpExprI<A,P,R>
		:
		
		ListOpCallI<A,ListOpI<P,R>>
		,
		ExprI<R>,
		
		ListOpExprI<A, P>

		where A:ExprI<P>


	{


	}
}
