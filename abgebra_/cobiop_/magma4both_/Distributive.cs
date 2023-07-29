using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.abgebra_.cobiop_.magma4both_
{
	/// <summary>
	/// multi is distributive over|(with respect to) add;
	///  a(b+c) = ab+ac;
	///  (b+c)a=ba+bc;
	/// </summary>
	/// semiring
	///		rig is reserved fro <see cref="dwelt_.Rig"/>
	public interface IDistributive
		:
		IMagma4both,

		_distributive.IPriorDistributive
		,
		_distributive.IPosteriorDistributive
	{
	}
}
