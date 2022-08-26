using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.expr_.call_
{
	public abstract class NaryA<TOp> : _nary.Op<TOp>
	//where TOp: nilnul.obj.op_.IBinary
	{
		protected NaryA(TOp op) : base(op)
		{
		}
		public override string ToString()
		{
			return $"{this.op}";
		}
	}
}
