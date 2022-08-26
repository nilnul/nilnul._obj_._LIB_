using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.func
{

	/// <summary>
	/// replace the "ret" with a new FuncI(var, ret)
	/// </summary>
	/// <typeparam name="TRet"></typeparam>
	public abstract partial class ExprReplaceA
	{

		static public FuncI<TInVar,TFuncAsRet> ExprReplace<TInVar,TFuncAsRet>(
			TFuncAsRet funcAsRet
		){


			throw new NotImplementedException();
		}


	}
}
