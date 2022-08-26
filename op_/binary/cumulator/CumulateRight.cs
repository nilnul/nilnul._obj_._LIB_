using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_.binary.cumulator
{
	/// <summary>
	/// imaging the 
	/// </summary>
	/// <typeparam name="T"></typeparam>
	///
	[Obsolete(nameof(obj.op_.binary.converse.cumulator))]
	public class CumulateRight<T> :
		nilnul.obj.Box1<CumulatorI<T>>
		,
		_cumulate_.OfSeq<T>     ///the difference with <see cref="Cumulate{T}"/> is in the body of the method, not the interface. So they share the same interface, but with different implementations; and the implementations have to be in the class, not interface.
	{
		public CumulateRight(CumulatorI<T> val) : base(val)
		{

		}

		/// <summary>
		/// imaging the list is arranged from origin to left, ie, leftwards; the initial is at the right side of the origin.
		/// We then at each step, apply the op of (item, accumulated)
		/// 
		/// </summary>
		/// <param name="list"></param>
		/// <returns></returns>
		public T cumulate(IEnumerator<T> list)
		{
			var accumulated = boxed.initial;
			while (list.MoveNext())
			{
				accumulated = boxed.binder.op(list.Current, accumulated);
			}

			return accumulated;
		}

		public T cumulate(IEnumerable<T> list)
		{
			return cumulate(list.GetEnumerator());
		}

	}
}
