using nilnul_obj.op;
using System;
using System.Net;

namespace nilnul.no
{
	public partial interface OpI< out R>
		: nilnul._op.ResultI<R>
		,nilnul._op.OpI_generic
	{
		R eval();

	}
	
}
