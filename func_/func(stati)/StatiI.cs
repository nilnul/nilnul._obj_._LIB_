using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.func
{
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="TInExpr">the type of the returned val of the expr in the func</typeparam>
	public partial interface StatiI<TInExpr> 
		
		: StatiI
		,
		_stati.SubstituteI_methodOfT<TInExpr>
	{


	}


	public partial interface StatiI
		:nilnul.obj.FuncI
	{

	}


}
