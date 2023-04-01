using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.split_
{
	/// <summary>
	/// convert a str to an element
	/// </summary>
	///
	public interface ToSeqI<T>
		:ISplit
		
	{
		IEnumerable<T> split(T x);
	}



}