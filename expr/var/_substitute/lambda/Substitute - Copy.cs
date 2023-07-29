using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj._expr.untyped.var._substitute.lambda
{


	/// <summary>
	/// expression is a special subtype of lambda.
	/// This is put under namespace "lambda" such as to explicate that not only expression but also lambda can be processed here.
	/// </summary>
	///
	[Obsolete()]
	public class Visitor : System.Linq.Expressions.ExpressionVisitor
	{
		private ParameterExpression _source;
		private Expression _target;

		public Visitor(ParameterExpression source, Expression target)
		{
			_source = source;
			_target = target;
		}

		protected override Expression VisitParameter(ParameterExpression node)
		{
			return node == _source ? _target : base.VisitParameter(node);
		}

		//public override Expression Visit(Expression node)
		//{
		//	return base.Visit(node);
		//}

	}

}
