using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_.binary.cumulator.co_
{
	/// <summary>
	/// if multi is distributive with respect to addition.
	/// </summary>
	/// <typeparam name="TAbelian"></typeparam>
	/// <typeparam name="TMonoid"></typeparam>
	public class Ring<TAbelian, TMonoid>
		: AbelianMonoid<TAbelian, TMonoid>
		where TAbelian : binary_.semigrp_.commutable.cumulator_.monoid_.IGrpOfAbelian
			where TMonoid : binary_.semigrp.cumulator_.IMonoid
	{







	}
}
