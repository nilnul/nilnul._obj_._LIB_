using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.func.op.compo.call
{
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="TInExpr"></typeparam>
	/// <typeparam name="TFunc"></typeparam>
	/// <remarks>
	/// apply 1st to 0th.
	/// </remarks>
	public partial class NullaryCompo<TInExpr, TFunc>
	{
		private obj.func.Nullary<TInExpr> _nullary;

		public obj.func.Nullary<TInExpr> nullary
		{
			get { return _nullary; }
			set { _nullary = value; }
		}
		private obj.func.FuncI<TInExpr,TFunc> _func1;

		public obj.func.FuncI<TInExpr,TFunc> func1
		{
			get { return _func1; }
			set { _func1 = value; }
		}

		TFunc eval() {
			return _func1.apply(_nullary.expr);		//if _func1 is nullary too, then return _func1.
		}

	}
}
