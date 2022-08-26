using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.func.expr_.call_
{
	/// <summary>
	/// func literals. not the named func. not the func name.
	/// eg:
	///		x=>x*3
	///		
	/// </summary>
	public interface UnaryI:
		IUnary
		,
		CallI
	{
	}
}
