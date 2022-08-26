using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.lambda
{
	/// <summary>
	/// the var is of type VarI(TVar)
	/// </summary>
	/// <typeparam name="TVar"></typeparam>
	public partial interface LambdaI_Var<in TVar>
		:LambdaI
		//where TVar is a lambda function: a constant.
	{


	}
}
