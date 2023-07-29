using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj
{
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <remarks>
	///  may contains variable while op.call doesnot.
	///  var, itself, doesn't form a closure when operated on by operaters. for example, x+1 is not a var, but an expression. So, we better define var in the scope of expr. Expr, on the other side, is closure. any exprs will be operated by operators , returning another expr.
	///  expr is shorter than var.expr
	/// </remarks>
	/// 
	[Obsolete()]

	public partial interface ExprI_inheritDynamic<out T>:ExprI_dynamic1
	{



	}
}
