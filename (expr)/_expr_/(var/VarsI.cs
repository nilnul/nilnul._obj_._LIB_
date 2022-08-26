using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj._expr_
{
	/// <summary>
	/// </summary>
	/// <typeparam name="TVars"></typeparam>
	public  interface VarsI<out TVars>
	{
		/// <summary>
		/// </summary>
		/// <returns></returns>
		TVars vars { get; }

	}

	public interface VarsI
		:VarsI<
			nilnul.obj.var.Set
		>
	{ }

}
