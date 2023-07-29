using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.abgebra_.cobiop_.semi4both_.semiring_
{

	/// distributive on the right; or on the left
	/// <summary>
	/// for plus, it's monoid;
	/// 0*a = 0;
	/// </summary>
	/// alias:
	///		semirig
	///		nearRig
	///			nearSemiRing
	///		semiNear
	public interface ISemiRig
		:
		ISemiring
		,
		abgebra_.IDwelt
		///it's not <see cref="IDistributive"/>, as it's distributive on one side only.

	{
	}
}
