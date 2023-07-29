//using nilnul.obj.algebra_.cobiop_.associative4both_.distributive_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.abgebra_.cobiop_.abel4add_.semi4mul_
{
	/// for add:
	///		it is not only a semigrp, but also an abelian group, <see cref="pargoid_.magma_.semigrp_.monoid_.grp_.IAbelian"/>;
	///		
	///	for multi:
	///		semigrp;
	///	(for multi, we may still lakc the identity:1. note 0 is neutral, not regarded as identity here; that is, identity is dedicated to 1, not 0 here)
	///
	/// <summary>
	/// pronounced "Rung";
	///  can be thought of as a ring without a multiplicative identity (or as a semiring with an additive inverse).
	/// </summary>
	/// <remarks>
	/// 
	///	as multi is distributive with respect to plus,
	///		this makes the neutral for plus, the nil, to be the annilator for multi, as:
	///			0*(0+0) = 0*0 + 0*0
	///			and 0*(0+0) = 0*0, per that it's abelian for addition;
	///			so 0*0 = 0*0 + 0*0
	///				so 0*0 =0
	///			0*(x) = (0+0)*x =  0*x + 0*x
	///				so 0*x =0
	///				
	/// </remarks>
	/// semiring
	///		reserved for <see cref="Rig"/>
	///		as analog with semigrp
	///	pseudo-ring
	/// 
	public interface IRng:
		ISemi4mul
		,
		_rng.IDitributive
		//IDistributive
		//,
		//algebra_.IDwelt /// as we require for add that it's abelian;
	{
	}
}
