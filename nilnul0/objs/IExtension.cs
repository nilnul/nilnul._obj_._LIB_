using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.objs
{
	/// <summary>
	/// <see cref="IObjs"/> can be regarded as :
	///		- a set if we ignore the repetitiveness of a member or the ordering
	///		- a str if we honor the ordering; this is infact equivalent to <see cref="IObjs"/>
	///		- a sortie if we honor the ordering but ignore the repetitiveness;
	///		- a bag/multiset if we ignore the ordering but honor the repetitiveness;
	/// </summary>
	internal class IExtension
	{
	}
}
