using nilnul_obj.op;
using System;
using System.Net;

namespace nilnul.obj.no
{
	public partial interface OpI< out R>
		:tuple.ResultI<R>
		,nilnul.obj.OpI
	{
		R eval();

	}
	
}
