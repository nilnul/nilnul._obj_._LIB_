using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.rel
{
	public partial class Const<D,R>
		:nilnul.obj.op.binary.Const<D,R,bool>
	{
		public Const(RelI<D,R> rel, op.ConstI<D> a,op.ConstI<R> b)
			:base(rel,a,b)
		{

		}
	}
}
