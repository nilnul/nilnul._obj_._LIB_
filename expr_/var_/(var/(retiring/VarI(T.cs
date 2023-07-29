using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj
{
	/// <summary>
	/// it can be a named variable, or an expression called anonymous variable containing named variables and literals.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	[Obsolete(nameof(expr_.Var))]
	public partial interface VarI<out T> 
		: 
		VarI
		,
		RefI<T>
	{


	}
}
