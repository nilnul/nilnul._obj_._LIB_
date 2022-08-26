using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.obj._expr;
using nilnul.obj.var.set;
using nilnul.obj.var.set.ordered;


namespace nilnul.obj._func
{
	public class Func
		: FuncI_dynamic
	{
		private Ordered _vars;

		public nilnul.obj.var.set.Ordered vars
		{
			get { return _vars; }
			set { _vars = value; }
		}

		private nilnul.obj._expr.ExprI_dynamic _expr;

		public nilnul.obj._expr.ExprI_dynamic expr
		{
			get { return _expr; }
			set { _expr = value; }
		}

		public Func(Ordered vars, ExprI_dynamic expr)
		{
			_vars = vars;
			_expr = expr;
		}


		public override string ToString()
		{
			return $"({_vars}){FuncX.GoesTo}{_expr}";
        }
		static public Func Create(ExprI_dynamic expr) {

			return new Func(  new Ordered(), expr);

		}

		static public Func Rename(Func func, _var.VarI_dynamicTyped var, _var.VarI_dynamicTyped varNew) {

			return new Func(func.vars.Rename(var,varNew), func.expr);
		}




		

		
	}
}
