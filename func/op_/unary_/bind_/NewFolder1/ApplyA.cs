using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.func
{

	public abstract class ApplyA< Var,  Ret>
		:ApplyI<Var,Ret>

	{

		public abstract Ret apply(
			
			expr.ExprI<Var> arg
		);

		public Ret apply( Var var){
			return apply( new obj.expr.Call<Var>(var) );
		}



	}
}
