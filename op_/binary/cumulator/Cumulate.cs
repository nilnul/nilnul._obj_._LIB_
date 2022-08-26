using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_.binary.cumulator
{
	public class Cumulate<T> :
		nilnul.obj.Box1<CumulatorI<T>>
		,
		_cumulate_.OfSeq<T>
	{
		public Cumulate(CumulatorI<T> val) : base(val)
		{

		}

		public Cumulate(T ini, obj.op_.BinaryI<T> op):this(
			new Cumulator<T>(ini,op)
		)
		{

		}

		public T cumulate(IEnumerable<T> seq)
		{
			return seq.Aggregate(
				this.boxed.initial
				,
				this.boxed.binder.op
			);
			//throw new NotImplementedException();
		}
		public T cumulate(params T[] seq) {
			return cumulate((IEnumerable<T>)seq);
		}
	}
}
