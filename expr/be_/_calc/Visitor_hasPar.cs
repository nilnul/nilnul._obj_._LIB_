using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.expr.be_._calc.lamda
{
	/// <summary>
	/// return false if found any par
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public class Visitor_hasPar : System.Linq.Expressions.ExpressionVisitor
	{

		private bool _hasAny=false;
		public bool hasAny { get { return _hasAny; } }

		

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
