using nilnul.obj._expr.expr0lamda.be_.nonlamda.vow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj._expr
{
	/// <summary>
	/// nonfunc lambda(expression)
	/// </summary>
	///
	[Obsolete(nameof(obj.IExpr))]
	public interface IUntyped
	{

	}

	[Obsolete(nameof(obj.ExprI4))]
	public interface UntypedI:IUntyped
	{
		/// <summary>
		/// expression is a special lambda. Here we use the name lambda to make explicit that the type is lambda (but the instance is only non-lambda expression)
		/// </summary>
		_expr.expr0lamda.be_.nonlamda.vow.Ee lambda { get; }

	}
	[Obsolete(nameof(obj.Expr4))]
	public class Untyped : _expr.expr0lamda.be_.nonlamda.vow.Ee
		,
		UntypedI
	{
		public Untyped(Expression val) : base(val)
		{
		}

		public Ee lambda => this;
	}
}
