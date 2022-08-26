using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.rel.closed
{
	public partial class Const<D>
		:rel.Const<D,D>
	{
		public Const(RelI<D,D> rel, op.ConstI<D> a,op.ConstI<D> b)
			:base(rel,a,b)
		{

		}
	}
}
