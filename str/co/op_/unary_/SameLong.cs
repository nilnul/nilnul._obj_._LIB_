using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str.co.op_.unary_
{
	static public class _SameLongX
	{
		
		static public IEnumerable<(T, T)> MakeSameLong<T>(
			IEnumerator<T> a
			,
			IEnumerator<T> b
		) {

			while (a.MoveNext())
			{
				if (b.MoveNext())
				{
					yield return (a.Current, b.Current);
				}
				else
				{
					yield return (a.Current, default);
				}
			}
			while (b.MoveNext())
			{
				yield return (default, b.Current);
			}

		}

		static public IEnumerable<(T, T)> MakeSameLong<T>(
			IEnumerable<T> a
			,
			IEnumerable<T> b
		) {
			return MakeSameLong<T>(
				a.GetEnumerator()
				,
				b.GetEnumerator()
			);
		}

	}
}
