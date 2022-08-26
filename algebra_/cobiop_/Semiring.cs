using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.algebra_.cobiop_
{
	/// <summary>
	///		like semigroup, we need the ops to be semigrp over the set
	///		and we also need the relation among the two ops to be distributive on at least one side.
	///  
	/// </summary>
	/// semiring
	///		semi implies :
	///			semigrp
	///			semidistributive.
	///		this is a lax constraint. And we expect any meaningful structure shall 
	///		rig is reserved fro <see cref="dwelt_.Rig"/>
	///	later we have :
	///		hemring
	///		nearring
	///		near semi ring
	///		quasi ring
	///		pseodo ring
	///
	public interface ISemiring : semigrp4both_.ISemiDistributive
	{
	}
}
