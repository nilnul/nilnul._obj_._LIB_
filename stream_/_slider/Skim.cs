using nilnul.obj._slider_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.stream_._slider
{
	/// <summary>
	/// 
	/// </summary>
	/// vs <see cref="IEnumerator{T}"/>, which
	///		1) has to move first to get a value, while <see cref="ISkim"/> already has a val set before any moving
	///		2) may end, while <see cref="ISkim"/> would never end.
	public interface ISkim { }
	public interface ISkim<T>:ISkim { }
	/// <summary>
	///		
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <remarks>
	/// alias:
	///		skim
	///		scroll
	///			reserved for peek of n terms
	///
	/// </remarks>
	public interface SkimI<T>
		:MoveNextI, CurrentI<T>
		,
		ISkim<T>

	{
	}
}
