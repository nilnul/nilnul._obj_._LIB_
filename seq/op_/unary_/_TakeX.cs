using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.seq.op_.unary_
{

	/// <summary>
	/// </summary>
	public static class _TakeX
	{
		static public IEnumerable<T> _Take_countAssumeNonnegLeSeqSize<T>(
			this IEnumerator<T> str
			,
			 int _countAssumePositive
		) {
			for (int i = 0; i < _countAssumePositive; i++)
			{
				str.MoveNext();
				yield return str.Current;
			}

		}
	}
}
