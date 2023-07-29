using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.abgebra_.cobiop_.semi4both_.commutive_
{
	/// <summary>
	/// a disjunct and a conjunct defined on the same set such that:
	///		x  |(x &y)=x
	///		x& (x|y) =x
	///		the above are called absorption rules.
	/// </summary>
	/// <seealso cref="obj.re_.poset_.Lattice"/> @ nilnul.rel later.
	/// vs:
	///		<see cref="IRingoid"/>
	///		, which we often requires distributivity, whileas for this we often require absorption;
	///		,which we often use for numerical models, whileas for this we often use for set theoretical models;
	///		
	public interface ILattice
		:
		abgebra_.pargoid_.magma_.semigrp_.band_.semilattice_.IDisjunct
		,
		abgebra_.pargoid_.magma_.semigrp_.band_.semilattice_.IConjunct
		,
		_lattice.IAbsorption
	{
	}
}
