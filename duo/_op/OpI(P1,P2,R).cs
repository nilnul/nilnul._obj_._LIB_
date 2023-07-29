using System;
using System.Net;

namespace nilnul.obj.duo._op
{
	public partial interface OpI<in P1, in P2,out R>
		:OpI<P1,P2>, tuple.OpI<R>
	{
		R eval(P1 a, P2 b);

	}
}
