using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.abgebra_.pargoid_.magma_.semigrp_.band_.semilattice_
{
	/// <summary>
	/// a  semilattice that is bounded
	///  that is, there exists one identity element,I,  such that x op I = x for all x
	///  
	/// 
	/// </summary>
	public interface IBounded:ISemilattice
		,
		IDwelt
		,
		IMonoid
	{
	}
}
