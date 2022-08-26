using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.algebra_.cobiop_.distributive_
{
	/// <summary>
	///  both op are associative.
	/// </summary>
	/// semiring
	///		rig is reserved fro <see cref="dwelt_.Rig"/>
	///		like semigroup, we need the ops to be associative.
	///
	[Obsolete(nameof( associative4both_.distributive_.ISemiring))]
	public interface ISemiring:IDistributive, associative4both_.distributive_.ISemiring
	{
	}
}
