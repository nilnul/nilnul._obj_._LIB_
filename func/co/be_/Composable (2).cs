using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.func.duo.be
{
	public partial class Composable
	{
		/// <summary>
		/// 
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <typeparam name="T1"></typeparam>
		/// <param name="func"></param>
		/// <param name="func1">
		/// right func is applied first, and the heading var is subsumed; the tail vars are kept and concat to the vars of the left func.
		/// </param>
		/// <returns></returns>
		static public bool Eval<T,T1>(
			Func_varsWithType_exprT<T> func
			,
			Func_varsWithType_exprT<T1> func1
		) {
			var expr = func.expr.substitute(func.vars.First(), func1.expr);

			throw new NotImplementedException();

		}
	}
}
