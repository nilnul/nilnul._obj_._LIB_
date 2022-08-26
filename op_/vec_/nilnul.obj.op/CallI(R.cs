using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.op
{
	/// <summary>
	/// a function call, once evaled, is of type R
	/// </summary>
	/// <typeparam name="R"></typeparam>
	public partial interface CallI<out R>
	{
		R eval();

	}
}
