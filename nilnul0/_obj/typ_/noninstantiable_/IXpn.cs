using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._obj.typ_.noninstantiable_
{
	/// <summary>
	/// the instance of xpn is not regarded as an ordiance instance (that's why you cannot return an xpn, but throw one)
	///
	/// In fact an instance of xpn means you are trying to instantiate a noninstantiable type, which implicitly embodies an exception.
	///
	/// So the instance of xpn shall be ragarded as in another world - the nonexisting world, where xpns coexist as subtypings, embodies some xpn infos, but carries no other relations meaningful to the real world.
	/// 
	/// </summary>
	public interface IXpn:INoninstantiable
	{
	}
}
