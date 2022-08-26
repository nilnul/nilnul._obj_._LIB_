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
	public class Visitor : System.Linq.Expressions.ExpressionVisitor
	{

		private bool _hasNoPar=true;
		public bool hasNoPar { get { return _hasNoPar; } }

		public override Expression Visit(Expression node)
		{
			if (_hasNoPar) 	return base.Visit(node);
			/// fasle == hasNoPar, so hasPar; we can break;
			return node;
		}

		protected override Expression VisitParameter(ParameterExpression node)
		{

			_hasNoPar = false;

			return node;

			//return base.VisitParameter(node);
		}
	}
}
