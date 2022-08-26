using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.set_._sed_
{
	/// <summary>
	/// the elements, other than seed, of a sed
	/// </summary>
	/// <remarks>
	///	alias:
	///		pericarp
	/// </remarks>
	public interface Peri<TSet>
		
		where TSet: nilnul.obj.Set_blankI
	{
		TSet peri { get; }
	}
}
