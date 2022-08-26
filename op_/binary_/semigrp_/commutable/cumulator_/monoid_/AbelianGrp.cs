using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_.binary_.semigrp_.commutable.cumulator_.monoid_
{
	/// <summary>
	/// given a <see cref="IMonoid"/>, if every element has an inverse. <see cref="monoid.be_.IInversible4all"/>
	/// eg:
	///		《0，+》 for integers
	/// </summary>
	public interface IGrpOfAbelian
		: IMonoid
		,
		semigrp.cumulator_.monoid_.grp_.IAbelian
	{
	}
}
