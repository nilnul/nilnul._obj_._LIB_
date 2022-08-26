using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._obj.typ.child.calc_.binary_.intersect_
{
	/// <summary>
	/// there are no instances; hence this is an exception
	/// </summary>
	/// <remarks>
	/// </remarks>
	public interface IXpn<P,A,B>
		: nilnul.obj_.IXpn
		,
		IIntersect<P,A,B>
		where A:P
		where B:P
	{
	}
}
