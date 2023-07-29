using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj._expr.untyped._vars.lambda
{
	public class Visitor : System.Linq.Expressions.ExpressionVisitor
	{
		private _expr.untyped_.var.Set _vars=new untyped_.var.Set();

		

		public _expr.untyped_.var.Set vars
		{
			get { return _vars; }
			set { _vars = value; }
		}
		

		protected override Expression VisitParameter(ParameterExpression node)
		{
			_vars.Add(
				new untyped_.Var(
					node
				)  /// var with same par is eq.
			);
			return base.VisitParameter(node);
		}
	}
}
