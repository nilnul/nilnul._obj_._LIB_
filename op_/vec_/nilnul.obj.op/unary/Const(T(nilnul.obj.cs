using System;
using System.Collections.Generic;
using System.Net;

namespace nilnul.obj.op.unary
{

	/// <summary>
	///Inherited from this class, a class can wrap a val of Type TOriginal into a more abstract type.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public partial class Const<T> : 

		nilnul.obj.op.Const<T>
		,
		
		ConstI<T>
	{
		

		public Const(T val)
			:base(val)
		{
			
		}
	

		static public implicit operator T(Const<T> a) {
			return a.val;
		}
		static public implicit operator Const<T>(T a) {
			return new Const<T>(a);
		}


		public T eval(T x)
		{
			return val;
		}

	


	}

}
