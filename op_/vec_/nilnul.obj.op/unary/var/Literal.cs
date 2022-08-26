using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.op.unary.var
{
	public partial class Literal<P,R>
		:nilnul.obj.var.Literal<op.UnaryI<P,R>>
		,
		nilnul.obj.op.unary.VarI<P,R>
	{
		public Literal(op.UnaryI<P,R> op)
			:base(op)
		{

		}
	}
}
