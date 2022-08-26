using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.rel
{
	public partial class Expr<D,R>
		:nilnul.obj.op.binary.Expr<D,R,bool>
	{
		public Expr(RelI<D,R> rel, op.ExprI3<D> a,op.ExprI3<R> b)
			:base(rel,a,b)
		{

		}
	}
}
