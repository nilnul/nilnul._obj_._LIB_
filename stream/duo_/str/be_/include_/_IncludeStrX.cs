using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.stream.duo_.str.be_
{
	/// <summary>
	/// include at top
	/// </summary>
	static public class _IncludeStrX
	{
		static public bool _IncludeStr_1str<T>(
			obj.StreamI2<T> seq
			,
			IEnumerable<T> str
			,
			IEqualityComparer<T> eq
		)
		{
			return _Include8topX._Include8top_1str(
				seq
				,
				str
				, eq
			);
		}

		static public bool _IncludeStr_1str<T>(
			obj.StreamI2<T> seq
			,
			IEnumerable<T> str
		) {

			return _IncludeStr_1str(seq,str, EqualityComparer<T>.Default);
		}

	}
}
