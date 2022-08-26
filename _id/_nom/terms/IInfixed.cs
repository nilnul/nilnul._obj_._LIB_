using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj._id._nom.terms
{

	/// <summary>
	/// eg:
	///		abcDef0Xyz
	///			when uppered:
	///				ABC_DEF_0_XYZ
	///					where 0 is still less precedent than the "_" in "ABC_DEF"
	///		abcDef0Xyz_uvw
	///			when uppred:
	///				ABC_DEF_0_XYZ__UVW
	///				
	/// </summary>
	/// <remarks>
	/// as this needs to be src doe, so it's manual up to the programmer. An implementation is not imminent; but an implementation might help explain and avoid ambiguity.
	/// </remarks>
	class IInfixed
	{
		
	}
}
