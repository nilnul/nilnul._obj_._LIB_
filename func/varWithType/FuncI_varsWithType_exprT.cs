using nilnul.obj.func.members;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.func.varWithType
{
	public partial interface FuncI_varsWithType_exprT<TInExpr>
		:VarsI
		,nilnul.obj.func.ExprAsMemberI<TInExpr>
		,
		FuncI_emptyDfn

	{

	}
}
