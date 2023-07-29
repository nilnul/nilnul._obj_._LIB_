using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj
{
	/// <summary>
	/// unbrella for expr of type T
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// 
	[Obsolete()]

	public interface ExprI_static<T>:ExprI_blank1
		,_expr.ReduceI1<T>,_expr.SubstituteI1<T>
	{


	}
}
