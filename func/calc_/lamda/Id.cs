using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.lambda
{
	public partial class Id<TVar>
		:nilnul.obj.op.UnaryI<VarI2<TVar>,ExprI2<TVar>>
	{
		private VarI2<TVar> _var;

		public VarI2<TVar> var
		{
			get { return _var; }
			set { _var = value; }
		}

	

		public ExprI2<TVar> expr
		{
			get { return _var; }
			
		}

		public Id(
			VarI2<TVar> var
			
		)
		{
			this.var = var;
		
		}

		public Id<TVar> substitute() {



			throw new NotImplementedException();
		
		
		}

		 public ExprI2<TVar> eval(ExprI2<TVar> arg)
		 {

			 return expr.substitute(var,arg);

			 throw new NotImplementedException();
		 }
	}
}
