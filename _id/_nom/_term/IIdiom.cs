using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj._id._nom._term
{
	/// <summary>
	/// a casible.
	/// casing as a whole.only for the initial and last char. there is no casing for any char inner of this 
	/// </summary>
	/// <remarks>
	/// eg:
	///		go2map
	///		ask4maps
	///		white0blue
	///		apple0peachs
	///		peach0apples
	///			shall be interpreted as (peach) or (apples)
	///		peach0applees
	///			shall be interpreted as (peach or apple) s
	///		peach0apple0es
	///			shall be interpreted as (peach or apple) s
	///			
	/// </remarks>
	public interface IIdiom
	{
	}
}
