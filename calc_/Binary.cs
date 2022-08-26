using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.obj.op_;

namespace nilnul.obj.calc_
{
	public  class Binary<R,TArg,TArg1, TOp>
		:nilnul.obj._call_.OpArgArg1A<TOp, TArg,TArg1>
		,CalcI<R>
		where TOp: nilnul.obj.op_.BinaryI<R>
		where TArg:CalcI<R>
		where TArg1:CalcI<R>
	{

		public Binary( 			
			TOp op, TArg arg,TArg1 arg1
		):base(op, arg, arg1)
		{

		}

		public R calc()
		{
			return op.op( arg.calc(),arg1.calc());
		}
	}
	public  class Binary<R,TArgArg1, TOp>
		:Binary<R, TArgArg1, TArgArg1,TOp>
		where TOp: nilnul.obj.op_.BinaryI<R>
		where TArgArg1:CalcI<R>
	{

		public Binary( 			
			TOp op, TArgArg1 arg,TArgArg1 arg1
		):base(op, arg,arg1)
		{

		}

	}

	public  class Binary<R, TOp>
		:Binary<R, CalcI<R>, CalcI<R>,TOp>
		where TOp: nilnul.obj.op_.BinaryI<R>
	{

		public Binary( 			
			TOp op, CalcI<R> arg,CalcI<R> arg1
		):base(op, arg,arg1)
		{

		}

	}
	
	public  class Binary<R>
		:Binary<  R, nilnul.obj.op_.BinaryI<R>>
		
	{

		public Binary(
			nilnul.obj.op_.BinaryI<R> op, CalcI<R> arg, CalcI<R> arg1
		):base(op, arg, arg1)
		{

		}

	}

}
