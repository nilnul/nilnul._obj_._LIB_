using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.func
{
	/// <summary>
	/// an expression that evaluates to a func.
	/// for the expression inside a func, use func1.body.
	/// </summary>
	public interface ExprI: nilnul.obj.expr_.typed_.GeneriI<obj.FuncI3>
	{
	}
}
