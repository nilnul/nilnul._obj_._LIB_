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
	[Obsolete(nameof(obj.str.IAccumulate))]
	public interface AccumulateI<T>
		:nilnul.obj.ConvertI<IEnumerable<T>, T>
	{
	}
}