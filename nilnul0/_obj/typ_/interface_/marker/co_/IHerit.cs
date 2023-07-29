using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._obj.typ_.interface_.marker.co_
{
	/// <summary>
	/// for marker interface, ChildType would be one more generic than BaseType.
	/// eg:
	///		IMarker0
	///		IMarker1{T}:IMarker0
	///	the typePara T is not a subtype of an implicit0default typePar of IMarker0. rather, IMarker0 doesnot implicitly define the typePar, but is without a definition of that typePar; in other words, T is undefined in IMarker0.
	/// </summary>
	/// <remarks>
	/// for giving typePar a materialized value, <see cref="membered.co_.IHerit"/>;
	/// This is understandable as this is not membered, we neednot to consider the definition, but to consider only the conceptual signature;
	/// </remarks>
	public interface IHerit
	{
	}
}
