using nilnul.obj.algebra_.cobiop_.associative4both_.distributive_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.algebra_.cobiop_.semiring_.dwelt_
{
	/// <summary>
	/// for plus
	///		it is abelian group
	///	for multi
	///		semigrp
	///	multi is distributive with respect to plus
	///		this makes the neutral for plus the annilator for multi, as:
	///			0*(0+0) = 0*0 + 0*0
	///			and 0*(0+0) = 0*0
	///			so 0*0 = 0*0 + 0*0
	///				so 0*0 =0
	///			0*(x) = (0+0)*x =  0*x + 0*x
	///				so 0*x =0
	/// 
	/// </summary>
	/// semiring
	///		reserved for <see cref="Rig"/>
	///		as analog with semigrp
	///	pseudo-ring
	///		
	/// 
	public interface IRng:ISemiring
		,
		algebra_.IDwelt
	{
	}
}
