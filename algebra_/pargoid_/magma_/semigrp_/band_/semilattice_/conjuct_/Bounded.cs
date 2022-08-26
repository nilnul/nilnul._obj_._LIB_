using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.algebra_.pargoid_.magma_.semigrp_.band_.semilattice_.conjunt_
{
	/// <summary>
	///  that is, there exists one identity element, called one rather than nil in order to avoid confusion later with <see cref="_semilattice.pre_.disjunct_.IBounded"/>, such that x * 1 = x for all x
	/// 
	/// </summary>
	public interface IBounded:
		semilattice_.IConjunct
		,
		semilattice_.IBounded
	{
	}
}
