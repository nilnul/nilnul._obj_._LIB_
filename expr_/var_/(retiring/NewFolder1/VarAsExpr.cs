using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj.var.stati;

namespace nilnul.obj.expr_
{
	




	public class VarAsExpr<T, TVar> : VarAsExpr<TVar>
		
		where TVar:nilnul.obj.VarI5<T>
	{
		public VarAsExpr(TVar var) : base(var)
		{
		}
	}

	

}
