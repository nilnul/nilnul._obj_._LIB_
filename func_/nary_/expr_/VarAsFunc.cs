using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.func
{
	public partial class VarAsFunc<T>
		:ExprAsMemberI<T>
		,
		ApplyI<object,VarAsFunc<T>>
	{
		private nilnul.obj.VarI3<T> _var;

		public nilnul.obj.VarI3<T> var
		{
			get { return _var; }
			set { _var = value; }
		}

		public VarAsFunc(nilnul.obj.VarI3<T> var)
		{
			_var = var;

		}




		public expr.ExprI<T> expr
		{
			get {

				return new nilnul.obj.expr.Var<T>(_var);
				
				throw new NotImplementedException(); 
			
			}
		}



		public VarAsFunc<T> apply(expr.ExprI<object> arg)
		{
			return this;

			throw new NotImplementedException();
		}
	}
}
