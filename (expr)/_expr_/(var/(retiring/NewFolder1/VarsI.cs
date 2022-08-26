using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj._expr._members
{
	/// <summary>
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public partial interface VarsI
	{
		/// <summary>
		/// </summary>
		/// <returns></returns>
		HashSet<_var.VarI_dynamicTyped> vars { get; }

	}
}
