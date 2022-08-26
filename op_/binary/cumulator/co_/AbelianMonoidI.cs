using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_.binary.cumulator.co_
{
	/// <summary>
	/// one is abelian; the other is monoid
	/// </summary>
	public interface AbelianMonoidI<TAbelian, TMonoid>
		where
		TAbelian: binary_.semigrp_.commutable.cumulator_.monoid_.IGrpOfAbelian
		where TMonoid: binary_.semigrp.cumulator_.IMonoid
	{
		

		 TAbelian abelia
		{
			get;
		}



		 TMonoid monoid
		{
			get;
		}






	}
}
