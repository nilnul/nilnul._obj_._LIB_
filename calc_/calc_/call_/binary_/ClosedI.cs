using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.call_.binary_
{
	public interface ClosedI<TOp, TArg> : nilnul.obj.call_._binary_.opArgArg1_.ArgSameTypeI<TOp, TArg>
		where TOp: nilnul.obj.op_._binary_.par1_.retParPar1_.ClosedI<TArg>
	{
		
	}
}
