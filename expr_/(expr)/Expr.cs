using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj
{
	

	public interface ExprI4:IExpr
	{
		/// <summary>
		/// expression is a special lambda. Here we use the name lambda to make explicit that the type is lambda (but the instance is only non-lambda expression)
		/// </summary>
		_expr.expr0lamda.be_.nonlamda.vow.Ee expr { get; }

	}
	public class Expr4 : _expr.expr0lamda.be_.nonlamda.vow.Ee
		,
		ExprI4
	{
		public Expr4(Expression val) : base(val)
		{
		}

		public _expr.expr0lamda.be_.nonlamda.vow.Ee expr => this;
	}
}
