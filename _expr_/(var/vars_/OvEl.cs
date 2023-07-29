using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj._expr_.vars_
{
	/// <summary>
	/// return a set of var
	/// </summary>
	/// <typeparam name="TEl">
	///
	/// </typeparam>
	public interface OvElI<  TEl>
		:_expr_.VarsI<
			nilnul.obj.var.SetI<TEl>
		>

	{

	}
}
