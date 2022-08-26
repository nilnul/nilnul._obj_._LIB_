using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.func.expr_
{
	/// <summary>
	/// in math, we might use f(x)=x such that f is a var standing for x=>x.
	/// eg:
	///		f
	///			as in f(x)=x*2
	///		g
	///			as in g=x=>x*x
	/// </summary>
	/// 
	public interface VarI:
		func.ExprI
		,
		obj.expr_.typed_.generi_.VarI<obj.FuncI3>
		,
		IVar
		
	{
	}
}
