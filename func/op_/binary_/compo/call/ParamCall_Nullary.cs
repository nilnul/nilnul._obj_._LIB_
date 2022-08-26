using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.func.op.compo.call
{
	public partial class ParamCall_Nullary< TInVar, TRet,TInExprOfNullary>

		where TRet:ExprReplaceI

	{
		private obj.func.op.Param.Call<TInVar,TRet> _paramCall;

		public obj.func.op.Param.Call<TInVar,TRet> paramCall
		{
			get { return _paramCall; }
			set { _paramCall = value; }
		}
		private obj.func.Nullary<TInExprOfNullary> _nullary;

		public obj.func.Nullary<TInExprOfNullary> nullary
		{
			get { return _nullary; }
			set { _nullary = value; }
		}

		public TRet eval() {
			return _paramCall.substitute2new(;
		}

	}
}
