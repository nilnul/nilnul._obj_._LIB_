using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.expr.be_._closed.lamda
{
	/// <summary>
	/// return false if found any par
	/// </summary>
	public class Visitor : System.Linq.Expressions.ExpressionVisitor
	{

		private bool _beOfType=true;
		public bool beOfType { get { return _beOfType; } }

		private Type _type;
		public Visitor(Type type)
		{
			_type = type;
		}

	

		public override Expression Visit(Expression node)
		{

			if (_beOfType)
			{
				return base.Visit(node);
			}
			/// fasle == hasNoPar, so hasPar; we can break;
			return node;
		}

		protected override Expression VisitParameter(ParameterExpression node)
		{
			if (node.Type != _type)
			{
				_beOfType = false;
			}
			return node;

			//return base.VisitParameter(node);
		}
	}
}
