using System;
using System.Collections.Generic;
using System.Net;

namespace nilnul.obj.op.unary.closed
{

	/// <summary>
	///Inherited from this class, a class can wrap a val of Type TOriginal into a more abstract type.
	/// </summary>
	/// <typeparam name="TR"></typeparam>
	public partial class Expr<T> : 

		Call_OpArgA<nilnul.obj.op.UnaryI<T,T>,ExprI3<T>>
		,

		nilnul.obj.op.ExprI3<T>
	{


		public Expr(
			nilnul.obj.op.UnaryI<T,T> op
			,
			ExprI3<T> arg
			
		)
			:base(op,arg)

			
		{

		}




	
	}

}
