using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj
{
	[Obsolete(nameof(expr_.Var))]
	public partial class Var2<T>
		:RefI<T>
		,
		VarI<T>
		,
		VarI2<T>
		,
		ExprI2<T>

	{

		public Var2() {
			
		}


		public ExprI2<T> substitute<V>( VarI2<V> var,ExprI2<V> expr)
		{
			if (typeof(V)==typeof(T) )
			{
				return substitute( var as VarI2<T>,expr as ExprI2<T> );
				
			}
			else
			{
				return this;
			}
			throw new NotImplementedException();
		}
	
		public ExprI2<T> substitute(VarI2<T> var, ExprI2<T> expr)
		{

			if (var == this)
			{
				return expr;

			}
			else
			{
				return this;

			}
			throw new NotImplementedException();
	

			throw new NotImplementedException();
		}

		
	}
}
