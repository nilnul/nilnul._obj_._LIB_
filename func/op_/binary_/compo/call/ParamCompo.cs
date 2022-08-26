using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.func.op.compo.call
{
	public partial class ParamCompo<TInVar,TRet, TInExpr, TFunc>
		:CallI
	{
		private obj.func.op.Param.Call<TInVar,TRet> _paramCall;

		public obj.func.op.Param.Call<TInVar,TRet> paramCall
		{
			get { return _paramCall; }
			set { _paramCall = value; }
		}
		private obj.func.FuncI<TInExpr,TFunc> _func1;

		public obj.func.FuncI<TInExpr,TFunc> func1
		{
			get { return _func1; }
			set { _func1 = value; }
		}






		
		

	}
}
