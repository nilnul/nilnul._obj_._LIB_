using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.algebra_.cobiop_.semiring_
{

	/// <summary>
	/// for plus, it's monoid
	/// 
	/// distributive on the right
	/// 0*a = 0
	/// </summary>
	/// semirig
	/// nearRig
	///		nearSemiRing
	public interface ISemiRig
		:
		ISemiring
		,
		algebra_.IDwelt
		//it's not semiring, as it's distributive on one side only.

	{
	}
}
