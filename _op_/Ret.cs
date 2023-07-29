using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj._op_
{
	/// <summary>
	/// Of Parameter; the initials are OP
	/// </summary>
	/// <typeparam name="R"></typeparam>
	///
	[Obsolete(nameof(obj.IOf1<R>))]
	public interface RetI<out R>
		:nilnul.obj._op_.BlankI
		,
		obj.IOf1<R>
	{
	}

	
}
