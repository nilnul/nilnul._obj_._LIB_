using System;
using System.Collections.Generic;
using System.Net;

namespace nilnul.obj.op.unary
{

	/// <summary>
	///Inherited from this class, a class can wrap a val of Type TOriginal into a more abstract type.
	/// </summary>
	/// <typeparam name="TR"></typeparam>
	public partial  class Expr1<TArg,TR> : 

		Call_OpArgA<nilnul.obj.op.UnaryI<TArg,TR>,ExprI3<TArg>>
		,

		nilnul.obj.op.ExprI3<TR>
	{


		public Expr1(
			nilnul.obj.op.UnaryI<TArg,TR> op
			,
			ExprI3<TArg> arg
			
		)
			:base(op,arg)

			
		{

		}




	
	}

}
