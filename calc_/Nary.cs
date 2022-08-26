using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.obj.op_;

namespace nilnul.obj.calc_
{
	public  class Nary<R,TOp>
		:nilnul.obj._call_.OpA2<
			TOp
		>
		,CalcI<R>
		where TOp: nilnul.obj.op_.NaryI<R>
	{

		public Nary( 			
			TOp op
		):base(op)
		{

		}

		public R calc()
		{
			return op.op();
		}
	}
	public class Nary<R> : Nary<R, nilnul.obj.op_.NaryI<R>>
	{
		public Nary(NaryI<R> op) : base(op)
		{
		}

		public Nary(R r):this(new obj.op_.Nary<R>(r) )
		{

		}
	}

}
