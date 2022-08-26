using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.op
{
	public interface ClosedOpI<T> : ClosedOpI
	{
	}
}


namespace nilnul_obj.op
{
	[Obsolete("nilnul.obj.op.ClosedOpI")]
	public interface ClosedOpI<T> : ClosedOpI, OpI<T>
	{
	}
}
