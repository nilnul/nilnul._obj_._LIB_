using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul_obj.op
{
	public interface ListOpConstI<A,P,R>
		:

		ListOpExprI<A, P, R>,
		
		ListOpConstI<A, P>
		,
		ConstI<R>

		where A:ConstI<P>


	{


	}
}
