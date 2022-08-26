using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_.binary.accumulator
{
	public class Cumulate<T> :
		nilnul.obj.Box1<AccumulatorI1<T>>
		,
		op_.binary.cumulator._cumulate_.OfSeq<T>
	{
		public Cumulate(AccumulatorI1<T> val) : base(val)
		{

		}

		public Cumulate(T ini, obj.op_.BinaryI<T> op,T annil, IEqualityComparer<T> eq):this(
			new Accumulator1<T>(ini,op,annil, eq)
		)
		{

		}

		public T cumulate(IEnumerable<T> seq)
		{

			return cumulate(seq.GetEnumerator());

			/// this is wrong, as the next nil would make the result annilated.
			//return seq.TakeWhile(x=> !this.boxed.elEq.Equals(x, boxed.annilator)).Aggregate(
			//	this.boxed.initial
			//	,
			//	this.boxed.binder.op
			//);
			//throw new NotImplementedException();
		}

		private T cumulate(IEnumerator<T> enumerator)
		{
			var r = this.boxed.initial;
			while (enumerator.MoveNext())
			{
				if (this.boxed.elEq.Equals( enumerator.Current , boxed.annilator) )
				{
					return boxed.annilator;

				}
				r = boxed.binder.op(r, enumerator.Current);

			}
			return r;
		//	throw new NotImplementedException();
		}

		public T cumulate(params T[] seq) {
			return cumulate((IEnumerable<T>)seq);
		}
	}
}
