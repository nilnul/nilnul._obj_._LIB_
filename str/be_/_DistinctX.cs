using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str.be_
{
	static public class _DistinctX
	{
		static public bool _IsDistinct_seqAssumeStr<T>(this IEnumerable<T> str, IEqualityComparer<T> eq)

		{
			if (str.Any())
			{
				var started = new nilnul.obj.seq_.Started<T>(str);

				return started.tail._IsDistinct_seqAssumeStr(eq) && nilnul.obj.seq_.str.be_._NotContainX.NotContain(started.tail, started.head, eq);
			}
			return true;

		}


		static public bool _IsDistinct_seqAssumeStr<T, TEq>(this IEnumerable<T> str)
			where TEq : IEqualityComparer<T>, new()

		{
			return _IsDistinct_seqAssumeStr(str, nilnul.obj_.Singleton<TEq>.Instance);

		}

		static public bool _IsDistinct_seqAssumeStr<T>(this IEnumerable<T> str)

		{
			return _IsDistinct_seqAssumeStr(str, EqualityComparer<T>.Default);

		}
	}
}