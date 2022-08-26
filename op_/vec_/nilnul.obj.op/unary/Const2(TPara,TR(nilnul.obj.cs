using System;
using System.Collections.Generic;
using System.Net;

namespace nilnul.obj.op.unary
{

	/// <summary>
	///Inherited from this class, a class can wrap a val of Type TOriginal into a more abstract type.
	/// </summary>
	/// <typeparam name="TR"></typeparam>
	public partial class Const2<TArg,TR> : 

		Call_OpArgA<nilnul.obj.op.UnaryI<TArg,TR>,ConstI<TArg>>
		,

		nilnul.obj.op.ConstI<TR>
	{


		public Const2(
			nilnul.obj.op.UnaryI<TArg,TR> op
			,
			ConstI<TArg> arg
			
		)
			:base(op,arg)

			
		{

		}




		public TR eval()
		{
			return op.eval(arg.eval());

			throw new NotImplementedException();
		}
	}

}
