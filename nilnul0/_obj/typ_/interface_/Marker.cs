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
	/// renaming marker interface breaks less than renaming nonmarker
	/// </remarks>
	/// <example></example>
	/// If the "I" is placed at the right, <see cref="Membered"/>
	/// 
	public interface  IMarker
	{
	}
}
