using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj
{
	/// <summary>
	/// convert a str to an element
	/// </summary>
	///
	[Obsolete()]
	public interface AccumulateI1<T>
	{
		T accumulate(nilnul.obj.StrI1<T> x);
	}
}