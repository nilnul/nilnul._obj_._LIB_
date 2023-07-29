using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.abgebra_.pargoid_.magma_.semigrp_.monoid_.grp_
{
	/// <summary>
	/// it's commutative;
	/// </summary>
	/// alias:
	///		abel
	public interface IAbelian
		:
		_abel.ICommutative
		,
		IGrp
		//,
		//monoid_.ICommutative

		//,
		//pargoid_.magma_.ICommutative
	{
	}
}
