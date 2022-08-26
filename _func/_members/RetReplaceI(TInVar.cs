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
	public partial interface RetReplaceI<TInVar>
	{

		FuncI<TInVar,TArg> retReplace<TArg>(TArg funcAsRet);


	}
}
