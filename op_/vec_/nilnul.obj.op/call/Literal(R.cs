using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.op.call
{
	public partial class Literal<R>
		:nilnul.obj.var.Literal<R>
		,
		RefI<R>
	{
		public Literal(R val)
			:base(val)
		{

		}
	}
}
