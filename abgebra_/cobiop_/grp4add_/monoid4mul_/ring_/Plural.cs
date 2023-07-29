using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.abgebra_.cobiop_.semi4both_.semiring_.dwelt_.rng_.ring_
{
	/// <summary>
	/// there are more than 1 elements in the set.
	/// </summary>
	/// <remarks>
	/// </remarks>
	/// let's prove that 0 != 1;
	/// we prove by contradiction as follows:
	/// ::::::::::
	/// If nil has an inverse <var>x</var>, then 0*x=(0+0) * x = 0x +0x. so 0x=0.
	/// so if nil and 1 are the same element.
	///		for nonnil x,
	///			1*x = x
	///			but 1 is 0, so 1*x=0*x = 0, so x=0. a contradiction.
	///		so nil and 1 must not be the same.
	///	::::::::::::
	/// 
	class Plural:abgebra_.IPlural
	{
	}
}
