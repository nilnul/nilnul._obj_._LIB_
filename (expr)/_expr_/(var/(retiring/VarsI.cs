using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj._expr
{
	/// <summary>
	/// </summary>
	/// <typeparam name="T"></typeparam>
	///
	[Obsolete()]
	public partial interface VarsI1
	{
		/// <summary>
		/// </summary>
		/// <returns></returns>
		HashSet<_var.VarI_dynamicTyped> vars { get; }

	}
}
