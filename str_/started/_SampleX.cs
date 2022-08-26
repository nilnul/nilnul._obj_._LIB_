using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str_.started
{
	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	/// alias:
	///		sample
	///			in statistics, sample mean a single set of values; so sample is a collection of singles.
	///		,
	///		single
	/// </remarks>
	static public class _SampleX
	{
		static public T Sample<T>(this IEnumerable<T> str) {
			return str.ElementAt(
				new Random().Next(str.Count())
			);
		}
	}
}
