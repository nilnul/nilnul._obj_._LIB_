using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.var.set.assign.interpret
{
	public interface EqI<TInVar,TRet>:
		IEqualityComparer<
			nilnul.obj.var.set.assign.Interpret<TInVar,TRet>
		>
	{
	}
}
