using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_.binary.cumulator.co_.ring_
{
	/// <summary>
	/// if every obj in the monoid, except 0, has an inverse.
	/// </summary>
	/// <typeparam name="TAbelian"></typeparam>
	/// <typeparam name="TMonoid"></typeparam>
	public interface FieldI<TAbelian, TMonoid>
		: RingI<TAbelian, TMonoid>
		where TAbelian : binary_.semigrp_.commutable.cumulator_.monoid_.IGrpOfAbelian
			where TMonoid : binary_.semigrp.cumulator_.IMonoid
	{





	}
}
