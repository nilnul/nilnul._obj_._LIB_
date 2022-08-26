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
	public partial interface ExprReplaceI
	{

		FuncI<TInVar,TFuncAsRet> exprReplace<TInVar,TFuncAsRet>(TFuncAsRet funcAsRet);


	}
}
