using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj.var.stati;

namespace nilnul.obj.expr_
{
	



	public class VarAsExpr<TVar>
		
		//where TVar :VarI1
	{
		private TVar _var;

		public TVar var
		{
			get { return _var; }
			set { _var = value; }
		}

	

		public VarAsExpr(TVar var)
		{
			_var = var;
		}

	
		
		public override string ToString()
		{
			return _var.ToString();
		}
	}


	

}
