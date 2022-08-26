using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.lambda
{
	public partial interface LambdaI<TVar,TExpr>
		:LambdaI<TExpr>,
		LambdaI_Var<TVar>
	{





	}
}
