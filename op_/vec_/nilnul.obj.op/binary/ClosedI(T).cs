using nilnul_obj.op;
using System;
using System.Net;

namespace nilnul.obj.op.binary
{
	public partial interface ClosedI<T>
		:
			nilnul.obj.op.BinaryI<T,T,T>
		,
		OpI<T,T,T>
	{

	}
}
