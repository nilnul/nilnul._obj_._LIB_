using System;
using System.Collections.Generic;
using System.Net;

namespace nilnul.obj.op.unary.closed
{

	/// <summary>
	///Inherited from this class, a class can wrap a val of Type TOriginal into a more abstract type.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public partial class Const<T> : 

		Call_OpArgA<nilnul.obj.op.UnaryI<T,T>,ConstI<T>>
		,

		nilnul.obj.op.ConstI<T>
	{


		public Const(
			nilnul.obj.op.UnaryI<T,T> op
			,
			ConstI<T> arg
			
		)
			:base(op,arg)

			
		{

		}




		public T eval()
		{
			return op.eval(arg.eval());

			throw new NotImplementedException();
		}
	}

}
