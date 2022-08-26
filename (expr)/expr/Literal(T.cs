using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.expr
{
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// []
	/// 
	[Obsolete("see call.Nullary")]
	public partial class Literal< T>
		:obj.expr.LiteralI<T>
	{

		private T _val;

		public T val
		{
			get { return _val; }
			set { _val = value; }
		}
		
		public Literal(T val)
		{
			this._val = val;
		}

		public ExprI<T> substitute<V>(VarI<V> var, ExprI<V> expr)
		{
			return this;

			throw new NotImplementedException();
		}

		public ExprI<T> demote()
		{
			return new Call<T>( 
				new nilnul.obj.call.Literal<T>(_val)
				
			);

			throw new NotImplementedException();
		}

		public ExprI<T> substitute<V>(VarI3<V> var, ExprI<V> expr)
		{
			return this;
			throw new NotImplementedException();
		}
	}
}
