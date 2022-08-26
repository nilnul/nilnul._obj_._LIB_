using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj_
{
	/// <summary>
	/// an euphemism(avoid conflict with keyword) of void. void is a singleton type in that:
	///		1) there is one and only one instance of the type
	///			in other words, all the instances of the type are the same - we cannot tell any difference among them.
	///	it's an instance, so the returned is fully known in advance. but it still need to return. If it doesnot return (for example runing infinitely), it's deemed the returned is not this type but an exception type (InfiniteRunException).
	/// </summary>
	/// <remarks>
	/// vs Xpn:
	///		Xpn type is a bottome type with no instances at all. (note the difference: 0 instances vs 1 instances)
	///		Xpn is the subtype of all types including the Vod. But Vod is subtype of obj, not the subtype of an arbitrary type.
	///
	/// </remarks>
	interface IVod
	{
	}
}
