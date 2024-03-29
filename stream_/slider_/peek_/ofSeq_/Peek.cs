﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.stream_.slider_.preview_
{

	/// <summary>
	/// ofSeq
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public class Peek<T> :
		nilnul.obj.Box1<IEnumerable<T>>
		,
		SliderI<T>
		,
		IEnumerable<(T,T) >
		,
		slider_._peek_.AheadI<T>
	{
		IEnumerator<T> _enumerator;
		public Peek(IEnumerable<T> val) : base(val)
		{
			_enumerator =val.GetEnumerator();

			_enumerator.MoveNext();
			_current = _enumerator.Current;
			_enumerator.MoveNext();

		}

		private T _current;

		public T current => _current;

		public T ahead {
			get {
				return _enumerator.Current;
			}
		}

		/// <summary>
		/// enumerate from the current position
		/// </summary>
		/// <returns></returns>
		public IEnumerator<(T, T)> GetEnumerator()
		{
			while (true)
			{
				yield return (_current, ahead);
				this.moveNext();

			}
			


		}

		public void moveNext()
		{
			_current = _enumerator.Current;
			_enumerator.MoveNext();
		}

		public T next()
		{
			return stream_._slider.CursorX.Next(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}


}
