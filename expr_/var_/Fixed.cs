using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.expr_.var_
{
	/// <summary>
	/// a var that wouldnot change. a constant such as PI, or imaginary "i".
	/// As the name constant has been taken by system.expressions.Constant, hence we use fixed as the name.
	/// </summary>
	/// alias:
	///		constant
	///		fixed
	///		invariate
	///		literal
	///		placeholder
	///		nominal
	public interface FixedI
		: obj.expr_.VarI
	{
	}
}
