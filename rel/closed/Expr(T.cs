using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.rel.closed
{
	public partial class Expr<D>
		:rel.Expr<D,D>
	{
		public Expr(RelI<D,D> rel, op.ExprI3<D> a,op.ExprI3<D> b)
			:base(rel,a,b)
		{

		}
	}
}
