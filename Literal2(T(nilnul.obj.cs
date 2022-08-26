using System;
using System.Net;

namespace nilnul.obj
{

	/// <summary>
	///Inherited from this class, a class can wrap a val of Type TOriginal into a more abstract type.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public partial class Literal2<T> 
		:RefI<T>
		,
		ExprI2<T>
	{
		public T val;

		public Literal2(T val)
		{
			this.val = val;
		}
	

		static public implicit operator T(Literal2<T> a) {
			return a.val;
		}
		static public implicit operator Literal2<T>(T a) {
			return new Literal2<T>(a);
		}


		public T eval()
		{
			return val;
		}





		public ExprI2<T> substitute<V>(VarI2<V> var, ExprI2<V> expr)
		{
			return this;
			throw new NotImplementedException();
		}
	}
}
