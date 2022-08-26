using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.func.op
{
	public partial class Apply
	{
		public class Call1<Func,ArgInExpr >
			:func.SubstituteI1

			where Func:func.FuncI1,
			func.VarAsPropI<ArgInExpr>

			//where TFunc:ApplicableI<TArg>
			//where TFunc:SubstituteInPlaceI<TArg>
			//where TFunc:ParamI<TArg>


		{
			private nilnul.obj.expr.ExprI< ArgInExpr> _arg;

			public nilnul.obj.expr.ExprI<ArgInExpr> arg
			{
				get { return _arg; }
				set { _arg = value; }
			}

			private Func _func;

			public Func func
			{
				get { return _func; }
				set { _func = value; }
			}

			public Call1( Func func, nilnul.obj.expr.ExprI<ArgInExpr> arg )
			{
				_arg = arg;
				_func = func;
			}

			public void substitute<TArg>(VarI3<TArg> var, expr.ExprI<TArg> expr)
			{

				return;
				throw new NotImplementedException();
			}
		}
	}
}
