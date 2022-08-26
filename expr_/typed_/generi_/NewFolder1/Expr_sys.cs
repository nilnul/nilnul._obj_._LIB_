using nilnul.obj._expr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj
{
	/// <summary>
	/// <see cref="obj.expr_.typed_.Generi{T}"/>
	/// </summary>
	/// <typeparam name="T"></typeparam>
	///
	[Obsolete()]
	public class Expr_sys<T> : _expr.untyped.be_.ofType_.typed.vow.Ee<T>
		,
		IExpr<T>
	{
		public Expr_sys(Expr4 val) : base(val)
		{
		}

		public Expr_sys(Expression val) : this(new Expr4(val))
		{
		}
	}
}
