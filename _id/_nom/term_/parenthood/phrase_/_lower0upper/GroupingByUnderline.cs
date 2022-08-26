using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj._id._nom.term_.parenthood.phrase_._lower0upper
{
	/// <summary>
	/// when casing uniformly like lower/upper case,
	///		we cannot use the case change as an anchor/0wideBoundary to seperate children.
	///			we will have to use underline.
	///	note, in child there might already be underline; hence between children, a str of underline with a incremented count is required.
	///	eg:
	///		ABC4XY_DEf_UVW__AAA
	/// </summary>
	/// <see cref="term.co.ILigature"/>, where same count of "_" around has higher tier.
	internal class IGroupingByUnderline
	{
	}
}
