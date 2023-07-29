using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.expr._vars.lambda
{
	public class Visitor : System.Linq.Expressions.ExpressionVisitor
	{
		private expr_.var.SetOfExprs _vars=new expr_.var.SetOfExprs();

		

		public expr_.var.SetOfExprs vars
		{
			get { return _vars; }
			set { _vars = value; }
		}
		

		protected override Expression VisitParameter(ParameterExpression node)
		{
			_vars.Add(
				new expr_.Var(
					node
				)  /// var with same par is eq.
			);
			return base.VisitParameter(node);
		}
	}
}
