using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.func
{
	/// in <see cref="func.ICalc"/>, func is not named; so a func cannot reference itself in recursion.
	/// but in <see cref="func.ICalc"/>, we also have par/var. We can simply feed a func into it, and that par will stand for the func, de facto named it.
	/// <summary>
	///  give the func a name.
	///  a func without name is <see cref="func.ICalc"/> or <see cref="func.calc_.ILamda"/>
	///  with name, it helps explain lambda, and it assists to describe lambda.
	///  
	/// </summary>
	/// <remarks>
	/// an expression that evaluates to a func.
	/// for the expression inside a func, use func1.body.
	/// </remarks>
	public interface IExpr
		:nilnul.obj.expr_.typed_.IGeneri<obj.IFunc>
	{

	}


}

/// This is in fact unnecessary,
///		as this can be done by <see cref="nilnul.obj.expr_.typed_.GeneriI<obj.FuncI3>"/>
///			and <see cref="func.CalcI"/>, if the type is a func.
/// This may be even detrimental,
///		when we introduce the explicit type parameter, the type would be different depending on the type par, and newly generated type can also be taken as the type par, resulting in an infinite sequence of types, and we would have no "closed" form, and may have never catch up with this even if we define func.expr, func.expr.expr, etc.
///		On the other hand, <see cref="func.CalcI"/> is closed, and the type of the par can be func, making it equivalent to <see cref="ExprI"/>, only with type dynamic not static. If the type of the rep of <see cref="func.CalcI"/> is <see cref="obj.IFunc"/>, then that rep is already an <see cref="func.IExpr"/>, so is the whole <see cref="func.CalcI"/> including <see cref="func.calc_.NaryI"/> and the body of <see cref="func.CalcI"/>
///		In all, every func.Expr can be regarded as <see cref="func.CalcI"/> with var in <see cref="obj.IExpr"/> being of type <see cref="obj.IFunc"/>, and:
///			that's closed.
///				no need to create more generic types on current type.
///  ((((((((((((((((((((((((((( in <see cref="nilnul.obj.func.ICalc"/>, the rep can be of type func or nonfunc. We can add <see cref="nilnul.obj.IVow"/> to constaint that type. We here make that type constraint to be generic (the type arg: <see cref="nilnul.obj.IFunc"/>)
///
/*
  with func.Expr, rather than func.Calc, we can restrict our scope to varOfFunc, not to varOfAnyObj.
 */


