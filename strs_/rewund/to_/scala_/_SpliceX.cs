using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.strs_.rewund.to_.scala_
{
	/// <see cref="obj.str.of_.unary_._RewindX"/>
	/// <summary>
	/// rewind the str of n tyime;
	/// </summary>
	static public class _SpliceX
	{

	/// <summary>
	/// rewind the str<paramref name="str"/> <paramref name="count"/> tyime;
	/// </summary>
	/// <remarks>
	///
	/// </remarks>
	/// vs:
	///		<see cref="strs.of_._RepeatX"/>, which repeat an element multiples times
		static public IEnumerable<T> _Rewind_0str_1nonneg<T>(IEnumerable<T> str, int count)
		{
			return Enumerable.Repeat(str, count).SelectMany(x=>x);
		
		}

	}
}
