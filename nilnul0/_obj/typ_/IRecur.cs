using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._obj.typ_
{

	/// <summary>
	/// for a recur type like <see cref="nilnul.txt_._versioned.version_"/>,which defines the sepcial case <see cref="nilnul.txt_._versioned.version_.IIdable"/> and <see cref="nilnul.txt_._versioned.version_._idable"/> first; so implementations shall be placed there, and generalized ones would be placed under <see cref="nilnul.txt_._versioned._version."/>
	/// </summary>
	/// <remarks>
	/// for recursion,
	///		the base clause shall alway come as the prime clause.
	///		before the extension and exclusion clauses.
	/// </remarks>
	class IRecur
	{
	}
}
