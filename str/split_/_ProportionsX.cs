using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str.split_
{
	static public class _ProportionsX
	{
		static public IEnumerable<IEnumerable<T>> _Proportions_sizeAssumeNonneg1TotalLeSeq<T> (IEnumerator<T> seq, IEnumerator<int> _sizes) {

			while (_sizes.MoveNext())
			{
				yield return str.op_.unary_._TakeX._Take_countAssumeNonnegLeSeqSize(
					 seq
					,
					 _sizes.Current
				);
	
			}
		}
		static public IEnumerable<IEnumerable<T>> _Proportions_sizeAssumeNonneg1TotalLeSeq<T> (IEnumerable<T> seq, IEnumerable<int> _sizes) {
			return _Proportions_sizeAssumeNonneg1TotalLeSeq(seq.GetEnumerator(),_sizes.GetEnumerator());
		}

	}
}
