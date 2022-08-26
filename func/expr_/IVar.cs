using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.func.expr_
{
	/// <summary>
	/// in math, we might use f(x)=x such that f is a var standing for x=>x.
	/// in <see cref="func.ICalc"/>, the rep(including par, and var) can be of type Func; and hence equiv to this. But using Gnerice here, we make that constraint to be static, not dynamic any more.
	/// </summary>
	/// 
	public interface IVar:
		nilnul.obj.expr_.typed_.generi_.IVar<obj.IFunc>
	{
	}
}
