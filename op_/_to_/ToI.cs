using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj._to_
{
	[Obsolete("namespace shall be: " + nameof(nilnul.obj.op_))]
	public interface ToI<in TSrc,out TDst>

	{
		TDst to(TSrc src);

	}
}
