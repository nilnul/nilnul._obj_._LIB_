using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.abgebra_.cobiop_.semi4both_
{

	///  both op are associative.
	/// <summary>
	///		like semigroup, we need the ops to be semigrp over the set
	///		and we also need the relation among the two ops(add, multi) to be distributive on at least one side (left distributive, or right distributive).
	///  
	/// </summary>
	/// <remarks>
	/// for each op, it's semigrp;
	/// for both ops, it's semidistributive|<see cref="cobiop.be_._distributive.IOneSideDistributive"/>;
	/// </remarks>
	/// semiring
	///		semi implies :
	///			semigrp
	///			semidistributive.
	///		this is a lax constraint. And we expect any meaningful structure shall inherit this;
	///		rig is reserved fro <see cref="dwelt_.Rig"/>
	///	later we have :
	///		hemring
	///			,
	///			half distributive
	///		nearring
	///		near semi ring
	///		quasi ring
	///		pseodo ring
	///		ringoid
	///
	public interface ISemiring : semi4both_.ISemiDistributive
	{
	}

}
