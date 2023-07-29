using System.Collections.Generic;

namespace nilnul.obj.stream_._slider
{
	/// <summary>
	/// 
	/// </summary>
	/// vs <see cref="IEnumerator{T}"/>, which
	///		1) has to move first to get a value, while <see cref="ISkim"/> already has a val set before any moving
	///		2) may end, while <see cref="ISkim"/> would never end.
	///	alias:
	///		skid
	///			move and pause
	///		slid
	///			past tense of slide
	///		slip
	///		
	///		skim
	///		cursor
	public interface ISkid { }
	public interface ISkid<T>:ISkid { }


}
