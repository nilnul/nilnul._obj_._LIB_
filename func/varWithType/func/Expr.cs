using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.var.varWithType.func
{
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <remarks>
	/// cast expr as func
	/// </remarks>
	public partial class Expr<T>
	{
		private nilnul.obj.expr.ExprI<T> _expr;

		public nilnul.obj.expr.ExprI<T> expr
		{
			get { return _expr; }
			set { _expr = value; }
		}

		public Expr(obj.expr.ExprI<T> expr)
		{
			_expr = expr;

		}
	}
}
