using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.func.op.compo.call
{
	public partial class ParamedCall<TInVar,TRet, TInExpr, TFunc>
		:CallI
		,
		ReduceI
	{
		private obj.VarI3<TInVar> _var;

		public obj.VarI3<TInVar> var
		{
			get { return _var; }
			set { _var = value; }
		}

		private compo.CallI _call;

		public compo.CallI call
		{
			get { return _call; }
			set { _call = value; }
		}


		public ParamedCall(
			obj.VarI3<TInVar> var
			,
			compo.CallI call
		)
		{
			_var = var;
			_call = call;

		}

		private void reduce() {


			(_call as ReduceI).reduce();
		}


		

		
		

	}
}
