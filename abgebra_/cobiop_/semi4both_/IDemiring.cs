using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.abgebra_.cobiop_.semi4both_
{
	/// <summary>
	/// distributive on both sides, <see cref="cobiop.be_.IDistributive"/>.
	/// </summary>
	/// alias:
	///		demiring
	///			"d" is the start of both "demiring" and "distributive."
	///		for hair-dyer,
	///			The biggest difference between semi and demi is permanency. Though both are temporary, demi lasts 24 to 28 shampoos, and semi lasts 3 to 6.
	public interface IDemiring
		:
		//ISemiring
		//,
		semi4both_.IDistributive
	{
	}


}
