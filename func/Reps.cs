using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.func
{
	/// <summary>
	/// as all the pars might appear in the  expr. So this include pars.
	/// If you wang only the body var, then user body.Vars.
	/// </summary>
	/// <remarks>
	/// alias:
	///		rep
	///			representation.
	///			replacible
	///			representative.
	///			holder
	///			changable.
	///		var
	///			func.var may mean an expr_.Var ov func.
	///				but we now use obj.expr_.Var. so obj.Var is vacanted
	///
	/// </remarks>
	static public class _RepsX
	{
		static public nilnul.obj.expr_.var.SetOfVars _Reps_assumeFlat(this LambdaExpression func) {
			return new obj.expr_.var.SetOfVars(func.Parameters
				.Concat(
					nilnul.obj.expr._VarsX1._Vars_assumeExpr(
						func.Body
					)
				)
			);
		}

	}
}
