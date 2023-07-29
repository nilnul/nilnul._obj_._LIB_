using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._obj.typ_.interface_.membered.co_
{
	/// <summary>
	/// for membered interface, ChildType would be one less generic than BaseType.
	/// eg:
	///		Marker0I{T}
	///		Marker1I:IMarker0{T}
	///	the typePara T is implicit0defaultedly defined in IMarker1.
	/// </summary>
	/// <remarks>
	///	the typePar {T} is materialized in Marker1I.
	/// </remarks>
	public interface IHerit
	{
	}
}
