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
	public partial class Var<T>
		:
		
		Var,

		VarI<T>
	{

		public Var(nilnul.obj.VarI1 var)
			:base(var)
		{

		}

		public ExprI<T> substitute<V>(VarI3<V> var, ExprI<V> expr)
		{
			if ( var==this.var)	///v must be T, or the subtype of T.
			{
				return expr as ExprI<T>;
				
			}
			return this;
			///
			throw new NotImplementedException();
		}

		public ExprI<T> demote()
		{
			return this;
			throw new NotImplementedException();
		}


	}
}
