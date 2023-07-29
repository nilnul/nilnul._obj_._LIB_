using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str.of_.unary_.rewind_
{
	/// <summary>
	/// rewind the str of n tyime;
	/// </summary>
	static public class _ByLoopX
	{

	/// <summary>
	/// rewind the str<paramref name="str"/> <paramref name="count"/> tyime;
	/// </summary>
	/// <remarks>
	///
	/// </remarks>
	/// vs:
	///		<see cref="of_._RepeatX"/>, which repeat an element multiples times
		static public IEnumerable<T> _Rewind_0str_1nonneg<T>(IEnumerable<T> str, int count)
		{

			for (int i = 0; i < count; i++)
			{
				foreach (var item in str)
				{
					yield return item;

				}
			}
		}

	}
}
