using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.obj.op_;

namespace nilnul.obj.calc_
{
	public  class Unary<R,TArg, TOp>
		:nilnul.obj._call_.OpArgA<TOp, TArg>
		,CalcI<R>
		where TOp: nilnul.obj.op_.UnaryI<R>
		where TArg:CalcI<R>
	{

		public Unary( 			
			TOp op, TArg arg
		):base(op, arg)
		{

		}

		public R calc()
		{
			return op.op( arg.calc());
		}
	}
	public  class Unary<R, TOp>
		:Unary<R, CalcI<R>, TOp>
		where TOp: nilnul.obj.op_.UnaryI<R>
	{

		public Unary( 			
			TOp op, CalcI<R> arg
		):base(op, arg)
		{

		}

	}
	
	public  class Unary<R>
		:Unary<  R, nilnul.obj.op_.UnaryI<R>>
		
	{

		public Unary(
			nilnul.obj.op_.UnaryI<R> op, CalcI<R> arg
		):base(op, arg)
		{

		}

	}

}
