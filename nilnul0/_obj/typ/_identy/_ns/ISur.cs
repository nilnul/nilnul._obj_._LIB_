using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._obj._typ._ns
{
	/// <summary>
	/// eg:
	///		abcDef in "abcDef.gh"
	///		_abc
	///		_abc_
	///		abc_
	///		abc_1
	///			versioned namespace is discouraged
	///		abc_0
	///			discouraged. unless "abc_" (without 0) brings about problem
	/// </summary>
	/// <remarks>
	/// type shall be full named. seg for the type shall be shortened.
	/// </remarks>
	/// alias:
	///		sur
	///			same initial as schema/space
	///		seg
	///		term
	///			term is reserved for unversioned two letter phase.
	public interface ISeg
	{
	}
}
