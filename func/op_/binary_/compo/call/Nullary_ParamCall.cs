using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.func.op.compo.call
{
	public partial class Nullary_ParamCall<TInExpr,   TRet1>
	{
		private obj.func.Nullary<TInExpr> _nullary;

		public obj.func.Nullary<TInExpr> nullary
		{
			get { return _nullary; }
			set { _nullary = value; }
		}
		private obj.func.op.Param.Call<TInExpr,TRet1> _paramCall;

		public obj.func.op.Param.Call<TInExpr,TRet1> paramCall
		{
			get { return _paramCall; }
			set { _paramCall = value; }
		}

		public TRet1 eval() {
			return _paramCall.apply(_nullary.expr);
		}

	}
}
