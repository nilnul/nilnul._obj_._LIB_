using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.abgebra_.cobiop_.semi4both_.semiring_.near_
{
	///	for mul,
	///		it's <see cref="abgebra_.pargoid_.magma_.ISemigrp"/>;
	/// <summary>
	/// for add,
	///		it's <see cref="abgebra_.pargoid_.magma_.semigrp_.monoid_.IGrp"/>;
	///	the distributiveness is left-sided;
	///		z(x+y)=zx + zy
	/// </summary>
	/// <remarks>
	///
	/// </remarks>
	public interface ILeftDistributive:INearRing
		,
		semiring_.ILeftDistributive
	{
	}



}
