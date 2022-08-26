using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.expr_.call_
{
	public abstract class UnaryA<TOp, TArg> : _unary.OpArg<TOp, TArg>
	//where TOp: nilnul.obj.op_.IBinary
	{
		protected UnaryA(TOp op, TArg arg) : base(op, arg)
		{
		}
		public override string ToString()
		{
			return $"{this.op}{this.arg}";
		}
	}
}
