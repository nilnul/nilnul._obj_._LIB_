using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._obj._typ.ns_.dwelt.seg_
{
	/// <summary>
	/// nonhead seg can not be "nilnul"
	/// but it can be nilnul0;
	/// we need this cuz that in visualstudio,
	///		we need a folder "nilnul" to contain types that is not an extension of the project namespace.
	///		the resource and the settings are named according to folder hier, thus "nilnul" appeared in the middle.
	///		to mitigate this, we rename the folder to "nilnul0"
	/// </summary>
	class Nonhead
	{
	}
}
