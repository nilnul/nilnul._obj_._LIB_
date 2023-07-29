using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.expr
{
	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	/// alias:
	///		Rep
	/// </remarks>
	static public class _VarsX1
	{
		public static nilnul.obj.expr_.var.SetOfExprs _Exprs_assumeExpr(this Expression expr)
		{
			var v = new expr. _vars.lambda.Visitor();
			v.Visit(expr);
			return v.vars;


		}
		static public nilnul.obj.expr_.var.SetOfExprs Exprs(this nilnul.obj.ExprI4 expr) {
			return _Exprs_assumeExpr(expr.expr);
		}
		public static nilnul.obj.expr_.var.SetOfVars _Vars_assumeExpr(this Expression expr)
		{
			var v = new expr. _vars.lambda.Visitor4pars();
			v.Visit(expr);
			return v.vars;


		}

		static public nilnul.obj.expr_.var.SetOfVars Vars(this nilnul.obj.ExprI4 expr) {
			return _Vars_assumeExpr(expr.expr);
		}




	}
}
