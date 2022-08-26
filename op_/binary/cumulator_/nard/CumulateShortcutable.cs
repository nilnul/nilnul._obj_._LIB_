using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_.binary.cumulator_.nard
{
	/// <summary>
	/// <seealso cref="obj.algebra_.pargoid_.magma_.semigrp_.monoid"/>
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public class CumulateShortcutable<T> :
		nilnul.obj.Box1<cumulator_.NardableI<T>>
		,
		cumulator._cumulate_.OfSeq<T>
		,
		cumulator._cumulate_.OfEnumeratorI<T>

	{
		private IEqualityComparer<T> _eq;

		public IEqualityComparer<T> eq
		{
			get { return _eq; }
			set { _eq = value; }
		}

		public CumulateShortcutable(cumulator_.NardableI<T> val, IEqualityComparer<T> eq) : base(val)
		{
			this._eq = eq;
		}

		

		public T cumulate(T first, IEnumerator<T> seq)
		{
			var r = first;

			while (seq.MoveNext())
			{
				if ( _eq.Equals(seq.Current , this.boxed.initial) )
				{
					return this.boxed.initial;
				}

				r= boxed.binder.op(
					seq.Current
					,
					r
				);

			}
			return r;
			//throw new NotImplementedException();
		}
		public T cumulate(T first, IEnumerable<T> seq)
		{
			return cumulate(first, seq.GetEnumerator());
		}

		public T _cumulate_assumeHeaded(IEnumerable<T> seq)
		{

			return cumulate(seq.First(), seq.Skip(1));
			//throw new NotImplementedException();
		}



		public T cumulate(IEnumerator<T> seq)
		{
			if (seq.MoveNext())
			{
				return cumulate(seq.Current,seq);

			}
			return this.boxed.initial;
			

		}
		public T cumulate(IEnumerable<T> seq)
		{

			return cumulate(seq.GetEnumerator());
			//throw new NotImplementedException();
		}
		public T cumulate(params T[] seq)
		{
			return cumulate((IEnumerable<T>)seq);
		}
		public T _cumulate_assumeHeaded(IEnumerator<T> seq)
		{
			seq.MoveNext();
			var r = seq.Current;
			return cumulate(r, seq);

			
		}

	}
}
