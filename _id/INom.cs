using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj._id
{
	/// 
	/// <summary>
	/// as id is a word with a letter starting, <see cref="INom"/> is at least one letter long.
	/// eg:
	///		a in a1
	///		_ in _1
	/// </summary>
	/// alias:
	///		nub
	///			which is used in nilnul.txt_._vered.INub
	///	vs:
	///		name
	///			used locally, dynamically meaning different things at different place.
	///
	/// https://learn.microsoft.com/en-us/dotnet/standard/design-guidelines/naming-guidelines
	public interface INom
	{
	}
}
