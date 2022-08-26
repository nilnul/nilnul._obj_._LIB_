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
	public class AbelianMonoid<TAbelian, TMonoid>
		where
		TAbelian: binary_.semigrp_.commutable.cumulator_.monoid_.IGrpOfAbelian
		where TMonoid: binary_.semigrp.cumulator_.IMonoid
	{
		private TAbelian _abelian;

		public TAbelian abelia
		{
			get { return _abelian; }
			set { _abelian = value; }
		}

		private TMonoid _monoid;

		public TMonoid monoid
		{
			get { return _monoid; }
			set { _monoid = value; }
		}






	}
}
