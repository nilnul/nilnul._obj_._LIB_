using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.seq.duo_.str.be_
{
	static public class _SeqIncludeStrX
	{
		static public bool _SeqIncludeStr_1str<T>(
			IEnumerable<T> seq
			,
			IEnumerable<T> str
			,
			IEqualityComparer<T> eq 
		) {

			return seq.Take(str.Count()).SequenceEqual(str,eq);
		}

		static public bool _SeqIncludeStr_1str<T>(
			IEnumerable<T> seq
			,
			IEnumerable<T> str
		) {

			return seq.Take(str.Count()).SequenceEqual(str);
		}

	}
}
