using nilnul_obj.op;
using System;
using System.Net;

namespace nilnul.obj.op.binary
{
	public partial interface OpI<in P1, in P2,out R>
		:BiOpI<P1,P2>,BiOpI<R>
	{
		R eval(P1 a, P2 b);

	}
}
