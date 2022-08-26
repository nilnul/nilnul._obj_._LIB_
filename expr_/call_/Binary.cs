using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.expr_.call_
{
	public abstract class BinaryA<TOp, TArg, TArg1> : _binary.OpArgArg1<TOp, TArg, TArg1>
	//where TOp: nilnul.obj.op_.IBinary
	{
		protected BinaryA(TOp op, TArg arg, TArg1 arg1) : base(op, arg, arg1)
		{
		}
		public override string ToString()
		{
			return $"{this.arg}{this.op}{this.arg1}";
		}
	}
	public abstract class BinaryA<TOp, TArg> : BinaryA<TOp, TArg,TArg>
	//where TOp: nilnul.obj.op_.IBinary
	{
		protected BinaryA(TOp op, TArg arg, TArg arg1) : base(op, arg, arg1)
		{
		}
		
	}

}
