using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.algebra_.cobiop_
{
	/// <summary>
	/// a disjunct and a conjunct defined on the same set such that:
	///		x  |(x &y)=x
	///		x& (x|y) =x
	///		the above are called absorption rules.
	/// </summary>
	/// <seealso cref="obj.re_.poset_.Lattice"/> @ nilnul.rel later.
	public interface ILattice
		:
		algebra_.pargoid_.magma_.semigrp_.band_.semilattice_.IDisjunct
		,
		algebra_.pargoid_.magma_.semigrp_.band_.semilattice_.IConjunct
	{
	}
}
