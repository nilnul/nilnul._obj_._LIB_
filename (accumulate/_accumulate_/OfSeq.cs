using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj._accumulate_
{
	/// <summary>
	/// convert a str to an element
	/// </summary>
	/// 
	public interface OfElI<T>
	{
		T accumulate(IEnumerable<T> x);
	}
}