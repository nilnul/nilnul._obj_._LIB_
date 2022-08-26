using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.expr_.call_.unary_
{
	/// <summary>
	/// eg:
	///		bool not(ExprI{bool} expr) is not closed, if expr is "int x > 0", for "x" is int, not bool
	/// </summary>
	public interface INonclosed
	{
	}
}
