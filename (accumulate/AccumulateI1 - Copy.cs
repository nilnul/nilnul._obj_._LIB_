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
	[Obsolete(nameof(str.IAccumulate))]
	public interface AccumulateI_ofEnumerable<T>
		:
		_accumulate_.OfElI<T>
	{
		//T accumulate(IEnumerable<T> x);
	}
}