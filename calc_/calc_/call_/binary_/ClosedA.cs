using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.call_.binary_
{
	public abstract class ClosedA<TOp, TArg> : nilnul.obj.call_._binary_.opArgArg1_.ArgSameTypeA<TOp, TArg>
		where TOp: nilnul.obj.op_._binary_.par1_.retParPar1_.ClosedI<TArg>
	{
		public ClosedA(TOp op, TArg arg, TArg arg1) : base(op, arg, arg1)
		{
		}
	}
}
