using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace nilnul.obj._stream_
{

	/// <summary>
	/// seek the current, and move to next;
	/// </summary>
	/// <remarks>
	/// this is preferred to <see cref="NextI{T}"/>, as explained in <see cref="stream_.SliderI{T}"/>
	/// </remarks>
	/// <typeparam name="T"></typeparam>
	/// <seealso cref="_next.MorphI{T}"/>
	/// 
	/// alias:
	///		peep
	///			which is in between <see cref="seq_.IKeep"/> and <see cref="seq_.IPeek"/>
	///		keek
	///		seek
	///			like peek, but this is a verb, and would change the state;
	///			starts with s, as does Stream
	///		seize
	///		get
	///		fetch
	///			a verb
	///		catch
	public interface PeepI<out T>
	{
		/// <summary>
		/// peek and keep
		/// </summary>
		/// <returns></returns>
		T peep();

	}

	


}
