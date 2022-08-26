using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.expr_.closed._vars
{
	public class Visitor<T> : System.Linq.Expressions.ExpressionVisitor
	{
		private expr_.var.Set<T> _vars=new expr_.var.Set<T>();

		public Expression Visit(obj.expr_.Closed1<T> expr)
		{
			return Visit(expr.ee.untyped.ee.lambda);
		}

		public expr_.var.Set<T> vars
		{
			get { return _vars; }
			set { _vars = value; }
		}
		

		protected override Expression VisitParameter(ParameterExpression node)
		{
			_vars.Add(
				new expr_.Var_sys<T>(
					node
				)  /// var with same par is eq.
			);
			return base.VisitParameter(node);
		}
	}
}
