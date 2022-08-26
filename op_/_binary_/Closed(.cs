using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_._binary_
{
	public interface ClosedI<T>
		:nilnul.obj.op_._binary_.RetParPar1I<T,T,T>
				, nilnul.obj.op_.ClosedI<T>

	{
	}
}
