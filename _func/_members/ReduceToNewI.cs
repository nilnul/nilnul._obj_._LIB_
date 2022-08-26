using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj._func._members
{
	public partial interface ReduceToNewI<out TRet>
	{
		TRet reduceToNew();

	}
}
