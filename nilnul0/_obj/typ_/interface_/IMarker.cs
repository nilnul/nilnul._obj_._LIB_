using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._obj.typ_.interface_
{
	/// <summary>
	/// In nilnul, marker interface is empty, ie, has no members.
	/// The name of marker interface starts with "I", ie, the "I" is placed at the left, not at the right.
	/// Marker interface is important to keep one concept in one place and consistent all over the place.
	/// </summary>
	/// <remarks>
	/// renaming marker interface breaks less than renaming nonmarker, as it only alters semantics, not syntax;
	/// this helps make, in an easy way, an umbrella term that can be passed in|out|on to make the parameter strong typed, as sometimes some types are hard to unify in a membered interface due to the lack of common members;
	/// useful as the where constraint for a generic parameter as sometimes we need to express the general requirement of a typePar semantically, not an implementation that would be inclusive enough;
	/// - it makes defining a concept easy, facilitating thinking;
	/// </remarks>
	/// <example></example>
	/// If the "I" is placed at the right, <see cref="Membered"/>
	/// alias:
	///		memberless;
	public interface  IMarker
	{
	}
}
