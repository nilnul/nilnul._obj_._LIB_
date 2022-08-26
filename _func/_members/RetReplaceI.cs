using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj._func._members
{

	/// <summary>
	/// replace the "ret" with a new FuncI(var, ret)
	/// </summary>
	/// <typeparam name="TRet"></typeparam>
	public partial interface RetReplaceI
	{

		FuncI<TInVar,TFuncAsRet> retReplace<TInVar,TFuncAsRet>(TFuncAsRet funcAsRet);


	}
}
