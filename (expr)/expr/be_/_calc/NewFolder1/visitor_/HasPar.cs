using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.expr.be_._calc.visitor_
{
	/// <summary>
	/// return false if found any par
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public class HasPar<T> : System.Linq.Expressions.ExpressionVisitor
	{

		private bool _hasAny=false;
		public bool hasAny { get { return _hasAny; } }

		public Expression Visit(ExprI_sys<T> expr)
		{
			return Visit(expr.sys);
		}

		public override Expression Visit(Expression node)
		{
			if (_hasAny) return node;
			return base.Visit(node);
		}

		protected override Expression VisitParameter(ParameterExpression node)
		{

			_hasAny = true;

			return node;

			//return base.VisitParameter(node);
		}
	}
}
