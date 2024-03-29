﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.seq_._peek
{

	/// <summary>
	/// the Current is still consistent with <see cref="ISeq"/>; but moveNext will return false, if the ahead reaches out of the seq (note here the current is still valid);
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public class Enumer<T> :
		nilnul.obj.Box1<IEnumerator<T>>
		,
		IEnumerator<T>
		,
		stream_.slider_._peek_.AheadI<T>
	{
		IEnumerator<T> _enumerator;
		public Enumer(IEnumerable<T> val) : base(val)
		{
			_enumerator = val.GetEnumerator();


			_enumerator.MoveNext();
			_current = _enumerator.Current;
			_enumerator.MoveNext();

		}

		private T _current;

		public T current => _current;

		public T ahead
		{
			get
			{
				return _enumerator.Current;
			}
		}

		/// <summary>
		/// enumerate from the current position
		/// </summary>
		/// <returns></returns>
		public IEnumerator<T> GetEnumerator()
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
