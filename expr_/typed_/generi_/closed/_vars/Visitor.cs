using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.expr_.typed_.generi_.closed._vars
{
	public class Visitor<T> : System.Linq.Expressions.ExpressionVisitor
	{
		private generi_.var.Set<T> _vars=new generi_.var.Set<T>();

		public Expression Visit(obj.expr_.typed_.generi_.Closed<T> expr)
		{
			return Visit(expr.ee.expr.ee);
		}

		public generi_.var.Set<T> vars
		{
			get { return _vars; }
			set { _vars = value; }
		}
		

		protected override Expression VisitParameter(ParameterExpression node)
		{
			_vars.Add(
				new expr_.typed_.generi_.Var<T>(
					node
				)  /// var with same par is eq.
			);
			return base.VisitParameter(node);
		}
	}
}
