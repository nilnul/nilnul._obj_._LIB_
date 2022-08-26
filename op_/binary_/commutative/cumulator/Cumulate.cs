using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_.binary_.commutative.cumulator
{
	/// <summary>
	/// there is no difference between cumulate right and cumulate left, as this is commutative.
	/// </summary>
	/// <typeparam name="T"></typeparam>

	public class Cumulate<T> :
		nilnul.obj.Box1<CumulatorI<T>>
		,
		binary.cumulator._cumulate_.OfSeq<T>
	{
		public Cumulate(CumulatorI<T> val) : base(val)
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
	}
}
